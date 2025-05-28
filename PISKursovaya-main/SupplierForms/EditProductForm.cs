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
    public partial class EditProductForm : Form
    {
        private BuisnessLogic buisnessLogic;
        private Product product;
        private BindingSource source;

        public EditProductForm(BuisnessLogic buisnessLogic, Product selectedProduct, int supplierId)
        {
            this.buisnessLogic = buisnessLogic;
            InitializeComponent();
            product = selectedProduct;
            BindData();
        }

        public void BindData()
        {
            source = new BindingSource();
            source.DataSource = product;

            textBoxArticle.DataBindings.Add("Text", source, nameof(product.product_article));
            textBoxName.DataBindings.Add("Text", source, nameof(product.product_name));
            numericCost.DataBindings.Add("Value", source, nameof(product.cost));
            checkBoxIsOnSale.DataBindings.Add("Checked", source, nameof(product.is_on_sale));
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            buisnessLogic.SaveChangedProduct(product);
            Close();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            buisnessLogic.DeleteProduct(product);
            Close();
        }
    }
}
