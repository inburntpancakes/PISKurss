namespace PISKursovaya
{
    partial class SupplierForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.dataGridProductList = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAcceptOrder = new System.Windows.Forms.Button();
            this.buttonDeclineOrder = new System.Windows.Forms.Button();
            this.buttonConfirmOrderProcessComplete = new System.Windows.Forms.Button();
            this.dataGridCurrentOrders = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridTransactionHistory = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxPhone = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAddress = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSupplierName = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSupplierId = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRefreshData = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCurrentOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionHistory)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 99);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1653, 734);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAddProduct);
            this.tabPage1.Controls.Add(this.buttonEditProduct);
            this.tabPage1.Controls.Add(this.dataGridProductList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1645, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список запчастей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(1325, 617);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(312, 71);
            this.buttonAddProduct.TabIndex = 2;
            this.buttonAddProduct.Text = "Добавить новую запчасть";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(1005, 617);
            this.buttonEditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(312, 71);
            this.buttonEditProduct.TabIndex = 1;
            this.buttonEditProduct.Text = "Редактировать выбранную запчасть";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // dataGridProductList
            // 
            this.dataGridProductList.AllowUserToAddRows = false;
            this.dataGridProductList.AllowUserToDeleteRows = false;
            this.dataGridProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductList.Location = new System.Drawing.Point(8, 7);
            this.dataGridProductList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridProductList.MultiSelect = false;
            this.dataGridProductList.Name = "dataGridProductList";
            this.dataGridProductList.ReadOnly = true;
            this.dataGridProductList.RowHeadersWidth = 51;
            this.dataGridProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProductList.Size = new System.Drawing.Size(1627, 602);
            this.dataGridProductList.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAcceptOrder);
            this.tabPage3.Controls.Add(this.buttonDeclineOrder);
            this.tabPage3.Controls.Add(this.buttonConfirmOrderProcessComplete);
            this.tabPage3.Controls.Add(this.dataGridCurrentOrders);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1645, 705);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Текущие заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAcceptOrder
            // 
            this.buttonAcceptOrder.Enabled = false;
            this.buttonAcceptOrder.Location = new System.Drawing.Point(1323, 617);
            this.buttonAcceptOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAcceptOrder.Name = "buttonAcceptOrder";
            this.buttonAcceptOrder.Size = new System.Drawing.Size(312, 71);
            this.buttonAcceptOrder.TabIndex = 5;
            this.buttonAcceptOrder.Text = "Принять заказ на выполнение";
            this.buttonAcceptOrder.UseVisualStyleBackColor = true;
            this.buttonAcceptOrder.Click += new System.EventHandler(this.buttonAcceptOrder_Click);
            // 
            // buttonDeclineOrder
            // 
            this.buttonDeclineOrder.Enabled = false;
            this.buttonDeclineOrder.Location = new System.Drawing.Point(7, 617);
            this.buttonDeclineOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeclineOrder.Name = "buttonDeclineOrder";
            this.buttonDeclineOrder.Size = new System.Drawing.Size(312, 71);
            this.buttonDeclineOrder.TabIndex = 4;
            this.buttonDeclineOrder.Text = "Отклонить заказ";
            this.buttonDeclineOrder.UseVisualStyleBackColor = true;
            this.buttonDeclineOrder.Click += new System.EventHandler(this.buttonDeclineOrder_Click);
            // 
            // buttonConfirmOrderProcessComplete
            // 
            this.buttonConfirmOrderProcessComplete.Enabled = false;
            this.buttonConfirmOrderProcessComplete.Location = new System.Drawing.Point(327, 617);
            this.buttonConfirmOrderProcessComplete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirmOrderProcessComplete.Name = "buttonConfirmOrderProcessComplete";
            this.buttonConfirmOrderProcessComplete.Size = new System.Drawing.Size(312, 71);
            this.buttonConfirmOrderProcessComplete.TabIndex = 3;
            this.buttonConfirmOrderProcessComplete.Text = "Подтвердить выполнение заказа";
            this.buttonConfirmOrderProcessComplete.UseVisualStyleBackColor = true;
            this.buttonConfirmOrderProcessComplete.Click += new System.EventHandler(this.buttonConfirmOrderProcessComplete_Click);
            // 
            // dataGridCurrentOrders
            // 
            this.dataGridCurrentOrders.AllowUserToAddRows = false;
            this.dataGridCurrentOrders.AllowUserToDeleteRows = false;
            this.dataGridCurrentOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCurrentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCurrentOrders.Location = new System.Drawing.Point(8, 7);
            this.dataGridCurrentOrders.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCurrentOrders.MultiSelect = false;
            this.dataGridCurrentOrders.Name = "dataGridCurrentOrders";
            this.dataGridCurrentOrders.ReadOnly = true;
            this.dataGridCurrentOrders.RowHeadersWidth = 51;
            this.dataGridCurrentOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCurrentOrders.Size = new System.Drawing.Size(1627, 602);
            this.dataGridCurrentOrders.TabIndex = 1;
            this.dataGridCurrentOrders.SelectionChanged += new System.EventHandler(this.dataGridCurrentOrders_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridTransactionHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1645, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "История покупок и поставок";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridTransactionHistory
            // 
            this.dataGridTransactionHistory.AllowUserToAddRows = false;
            this.dataGridTransactionHistory.AllowUserToDeleteRows = false;
            this.dataGridTransactionHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransactionHistory.Location = new System.Drawing.Point(8, 7);
            this.dataGridTransactionHistory.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridTransactionHistory.MultiSelect = false;
            this.dataGridTransactionHistory.Name = "dataGridTransactionHistory";
            this.dataGridTransactionHistory.ReadOnly = true;
            this.dataGridTransactionHistory.RowHeadersWidth = 51;
            this.dataGridTransactionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTransactionHistory.Size = new System.Drawing.Size(1627, 690);
            this.dataGridTransactionHistory.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.richTextBoxPhone);
            this.tabPage4.Controls.Add(this.richTextBoxAddress);
            this.tabPage4.Controls.Add(this.richTextBoxSupplierName);
            this.tabPage4.Controls.Add(this.richTextBoxSupplierId);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1645, 705);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Данные поставщика";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Идентификатор";
            // 
            // richTextBoxPhone
            // 
            this.richTextBoxPhone.Location = new System.Drawing.Point(533, 349);
            this.richTextBoxPhone.Name = "richTextBoxPhone";
            this.richTextBoxPhone.ReadOnly = true;
            this.richTextBoxPhone.Size = new System.Drawing.Size(375, 31);
            this.richTextBoxPhone.TabIndex = 3;
            this.richTextBoxPhone.Text = "";
            // 
            // richTextBoxAddress
            // 
            this.richTextBoxAddress.Location = new System.Drawing.Point(533, 280);
            this.richTextBoxAddress.Name = "richTextBoxAddress";
            this.richTextBoxAddress.ReadOnly = true;
            this.richTextBoxAddress.Size = new System.Drawing.Size(375, 31);
            this.richTextBoxAddress.TabIndex = 2;
            this.richTextBoxAddress.Text = "";
            // 
            // richTextBoxSupplierName
            // 
            this.richTextBoxSupplierName.Location = new System.Drawing.Point(533, 213);
            this.richTextBoxSupplierName.Name = "richTextBoxSupplierName";
            this.richTextBoxSupplierName.ReadOnly = true;
            this.richTextBoxSupplierName.Size = new System.Drawing.Size(375, 31);
            this.richTextBoxSupplierName.TabIndex = 1;
            this.richTextBoxSupplierName.Text = "";
            // 
            // richTextBoxSupplierId
            // 
            this.richTextBoxSupplierId.Location = new System.Drawing.Point(533, 147);
            this.richTextBoxSupplierId.Name = "richTextBoxSupplierId";
            this.richTextBoxSupplierId.ReadOnly = true;
            this.richTextBoxSupplierId.Size = new System.Drawing.Size(375, 31);
            this.richTextBoxSupplierId.TabIndex = 0;
            this.richTextBoxSupplierId.Text = "";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1414, 26);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(248, 66);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выйти из личного кабинета";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.Location = new System.Drawing.Point(1150, 26);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(248, 66);
            this.buttonRefreshData.TabIndex = 2;
            this.buttonRefreshData.Text = "Обновить данные";
            this.buttonRefreshData.UseVisualStyleBackColor = true;
            this.buttonRefreshData.Click += new System.EventHandler(this.buttonRefreshData_Click);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.buttonRefreshData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierForm";
            this.Text = "Личный кабинет поставщика";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCurrentOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionHistory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.DataGridView dataGridProductList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.DataGridView dataGridCurrentOrders;
        private System.Windows.Forms.Button buttonConfirmOrderProcessComplete;
        private System.Windows.Forms.DataGridView dataGridTransactionHistory;
        private System.Windows.Forms.Button buttonDeclineOrder;
        private System.Windows.Forms.Button buttonAcceptOrder;
        private System.Windows.Forms.RichTextBox richTextBoxSupplierId;
        private System.Windows.Forms.RichTextBox richTextBoxSupplierName;
        private System.Windows.Forms.RichTextBox richTextBoxAddress;
        private System.Windows.Forms.RichTextBox richTextBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRefreshData;
    }
}