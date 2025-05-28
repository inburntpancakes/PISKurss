using PISKursovaya.FirmForms;
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
    public partial class FirmForm : SubForm
    {
        private BuisnessLogic buisnessLogic;
        public FirmForm(BuisnessLogic buisnessLogic, int userId)
        {
            this.buisnessLogic = buisnessLogic;
            InitializeComponent();
            BindData();
            RefreshData();
        }

        private void BindData()
        {
            dataGridTransactionHistory.DataBindingComplete += (sender, e) => { RedrawDataGridTransactionHistory(); };
        }

        private void RefreshData()
        {
            List<Product> products = buisnessLogic.GetProductsOnSale();
            dataGridProductList.DataSource = products;

            List<Order> ordersHistory = buisnessLogic.GetAllOrders();
            dataGridTransactionHistory.DataSource = ordersHistory;

            dataGridCurrentOrders.DataSource = buisnessLogic.GetAllOrdersInProgress();

            dataGridSuppliers.DataSource = buisnessLogic.GetAllSuppliers();
        }

        private void buttonConfirmOrderProcessComplete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Подтвердить выполнение заказа?\nДля отправки заказа в историю фирма и поставщик должны вместе подтвердить его выполнение.", "Подтверждение", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            Order selectedOrder = (Order)dataGridCurrentOrders.SelectedRows[0].DataBoundItem;
            buisnessLogic.ConfirmOrderInProgressByFirm(selectedOrder);
            RefreshData();
            MessageBox.Show("Заказ успешно подтвержден.", "Подтверждение");
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

        private void buttonOrderProduct_Click(object sender, EventArgs e)
        {
            if (dataGridProductList.SelectedRows.Count < 1) { MessageBox.Show("Запчасть не выбрана."); return; }

            OrderProductForm addProductWindow = new OrderProductForm(buisnessLogic, (Product)dataGridProductList.SelectedRows[0].DataBoundItem);
            addProductWindow.ShowDialog();
            RefreshData();
        }

        private void dataGridCurrentOrders_SelectionChanged(object sender, EventArgs e)
        {
            buttonConfirmOrderProcessComplete.Enabled = false;
            buttonRecallOrder.Enabled = false;

            if (dataGridCurrentOrders.SelectedRows.Count < 1) { return; }
            Order selectedOrder = (Order)dataGridCurrentOrders.SelectedRows[0].DataBoundItem;

            buttonRecallOrder.Enabled = true;

            switch (selectedOrder.status)
            {
                case OrderStatus.AwaitsFirmConfirmation:
                case OrderStatus.InProgress:
                    buttonConfirmOrderProcessComplete.Enabled = true;
                    break;
            }
        }

        private void buttonRecallOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите отозвать заказ? Отозванный заказ будет считаться выполненным и последующая работа с ним будет невозможна.", "Отозвать заказ", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            Order selectedOrder = (Order)dataGridCurrentOrders.SelectedRows[0].DataBoundItem;
            buisnessLogic.RecallOrder(selectedOrder);
            RefreshData();
            MessageBox.Show("Заказ успешно отозван.", "Отозвать заказ");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CloseSubForm();
        }

        private void buttonRefreshData_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
