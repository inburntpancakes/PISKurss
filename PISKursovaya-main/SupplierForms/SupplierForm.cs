using PISKursovaya.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISKursovaya
{
    public partial class SupplierForm : SubForm
    {
        private BuisnessLogic buisnessLogic;
        private int userId;

        public SupplierForm(BuisnessLogic buisnessLogic, int userId)
        {
            this.buisnessLogic = buisnessLogic;
            this.userId = userId;
            InitializeComponent();
            BindData();
            RefreshData();
        }

        private void BindData()
        {
            dataGridTransactionHistory.DataBindingComplete += (sender, e) => { RedrawDataGridTransactionHistory(); };
            dataGridProductList.DataBindingComplete += (sender, e) => RedrawDataGridProductList();
        }

        private void RefreshData()
        {
            List<Product> products = buisnessLogic.GetProductsOfSupplier(userId);
            dataGridProductList.DataSource = products;

            List<Order> orders = buisnessLogic.GetOrdersInProgressOfSupplier(userId);
            dataGridCurrentOrders.DataSource = orders;

            List<Order> ordersHistory = buisnessLogic.GetOrdersOfSupplier(userId);
            dataGridTransactionHistory.DataSource = ordersHistory;

            Supplier supplier = buisnessLogic.GetSupplierByUserId(userId);
            richTextBoxSupplierId.Text = supplier.user_id.ToString();
            richTextBoxSupplierName.Text = supplier.supplier_name;
            richTextBoxAddress.Text = supplier.address;
            richTextBoxPhone.Text = supplier.phone;
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dataGridProductList.SelectedRows[0].DataBoundItem;
            EditProductForm editProductWindow = new EditProductForm(buisnessLogic, selectedProduct, userId);
            editProductWindow.ShowDialog();
            RefreshData();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductWindow = new AddProductForm(buisnessLogic, userId);
            addProductWindow.ShowDialog();
            RefreshData();
        }

        private void buttonConfirmOrderProcessComplete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите подтвердить выполнение заказа? Для отправки заказа в историю фирма и поставщик должны вместе подтвердить его выполнение.", "Подтверждение", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            Order selectedOrder = (Order)dataGridCurrentOrders.SelectedRows[0].DataBoundItem;
            buisnessLogic.ConfirmOrderInProgressBySupplier(selectedOrder);
            RefreshData();
            MessageBox.Show("Заказ успешно подтвержден.", "Подтверждение");
        }

        private void dataGridCurrentOrders_SelectionChanged(object sender, EventArgs e)
        {
            buttonAcceptOrder.Enabled = false;
            buttonDeclineOrder.Enabled = false;
            buttonConfirmOrderProcessComplete.Enabled = false;

            if (dataGridCurrentOrders.SelectedRows.Count < 1) { return; }
            Order selectedOrder = (Order)dataGridCurrentOrders.SelectedRows[0].DataBoundItem;

            buttonDeclineOrder.Enabled = true;

            switch (selectedOrder.status)
            {
                case OrderStatus.AwaitsSupplierAcceptance:
                    buttonAcceptOrder.Enabled = true;
                    break;
                case OrderStatus.AwaitsSupplierConfirmation:
                case OrderStatus.InProgress:
                    buttonConfirmOrderProcessComplete.Enabled = true;
                    break;
            }
        }

        private void RedrawDataGridTransactionHistory()
        {
            foreach (DataGridViewRow row in dataGridTransactionHistory.Rows)
            {

                switch (Order.GetOrderStatusByString((string)row.Cells[nameof(Order.orderStatus)].Value))
                {
                    case OrderStatus.AwaitsSupplierAcceptance:
                    case OrderStatus.AwaitsSupplierConfirmation:
                    case OrderStatus.AwaitsFirmConfirmation:
                    case OrderStatus.InProgress:
                        row.DefaultCellStyle.BackColor = Color.White;
                        break;
                    default:
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        break;
                }
            }
        }

        private void RedrawDataGridProductList()
        {
            foreach (DataGridViewRow row in dataGridProductList.Rows)
            {

                switch ((bool)row.Cells[nameof(Product.is_on_sale)].Value)
                {
                    case true:
                        row.DefaultCellStyle.BackColor = Color.White;
                        break;
                    case false:
                        row.DefaultCellStyle.BackColor = Color.LightGray;
                        break;
                }
            }
        }

        private void buttonDeclineOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите отклонить заказ? Отклоненный заказ будет считаться выполненным и последующая работа с ним будет невозможна.", "Отклонить заказ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            Order selectedOrder = (Order)dataGridCurrentOrders.SelectedRows[0].DataBoundItem;
            buisnessLogic.DeclineOrder(selectedOrder);
            RefreshData();
            MessageBox.Show("Заказ успешно отклонен.", "Отклонить заказ");
        }

        private void buttonAcceptOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите принять заказ на выполнение?", "Отклонить заказ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            Order selectedOrder = (Order)dataGridCurrentOrders.SelectedRows[0].DataBoundItem;
            buisnessLogic.AcceptOrder(selectedOrder);
            RefreshData();
            MessageBox.Show("Заказ успешно принят на выполнение.", "Принять заказ");
        }

        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CloseSubForm();
        }
    }
}
