using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISKursovaya.FirmForms
{
    public partial class OrderProductForm : Form
    {
        private BuisnessLogic buisnessLogic;
        private Product product;

        public OrderProductForm(BuisnessLogic buisnessLogic, Product selectedProduct)
        {
            this.buisnessLogic = buisnessLogic;
            product = selectedProduct;
            InitializeComponent();

            textBoxArticle.Text = selectedProduct.product_article;
            textBoxName.Text = selectedProduct.product_name;
            textBoxSupplierId.Text = selectedProduct.supplier_id.ToString();
            textBoxCost.Text = selectedProduct.cost.ToString();
            numericQuantity_ValueChanged(null, null);
        }

        private void buttonOrderProduct_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order(product.supplier_id, product.product_article, (int)numericQuantity.Value, Convert.ToInt32(textBoxOverallCost.Text));
            buisnessLogic.AddOrder(newOrder);
        }

        private void numericQuantity_ValueChanged(object sender, EventArgs e)
        {
            textBoxOverallCost.Text = Convert.ToString(numericQuantity.Value * product.cost);
        }
    }
}
