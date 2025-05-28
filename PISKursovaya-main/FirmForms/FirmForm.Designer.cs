namespace PISKursovaya
{
    partial class FirmForm
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
            this.buttonOrderProduct = new System.Windows.Forms.Button();
            this.dataGridProductList = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonRecallOrder = new System.Windows.Forms.Button();
            this.buttonConfirmOrderProcessComplete = new System.Windows.Forms.Button();
            this.dataGridCurrentOrders = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridTransactionHistory = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridSuppliers = new System.Windows.Forms.DataGridView();
            this.buttonRefreshData = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCurrentOrders)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionHistory)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).BeginInit();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonOrderProduct);
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
            // buttonOrderProduct
            // 
            this.buttonOrderProduct.Location = new System.Drawing.Point(1323, 617);
            this.buttonOrderProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrderProduct.Name = "buttonOrderProduct";
            this.buttonOrderProduct.Size = new System.Drawing.Size(312, 71);
            this.buttonOrderProduct.TabIndex = 2;
            this.buttonOrderProduct.Text = "Заказать запчасть";
            this.buttonOrderProduct.UseVisualStyleBackColor = true;
            this.buttonOrderProduct.Click += new System.EventHandler(this.buttonOrderProduct_Click);
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
            this.tabPage3.Controls.Add(this.buttonRecallOrder);
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
            // buttonRecallOrder
            // 
            this.buttonRecallOrder.Enabled = false;
            this.buttonRecallOrder.Location = new System.Drawing.Point(8, 617);
            this.buttonRecallOrder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRecallOrder.Name = "buttonRecallOrder";
            this.buttonRecallOrder.Size = new System.Drawing.Size(312, 71);
            this.buttonRecallOrder.TabIndex = 5;
            this.buttonRecallOrder.Text = "Отозвать заказ";
            this.buttonRecallOrder.UseVisualStyleBackColor = true;
            this.buttonRecallOrder.Click += new System.EventHandler(this.buttonRecallOrder_Click);
            // 
            // buttonConfirmOrderProcessComplete
            // 
            this.buttonConfirmOrderProcessComplete.Enabled = false;
            this.buttonConfirmOrderProcessComplete.Location = new System.Drawing.Point(1323, 617);
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
            this.dataGridTransactionHistory.Size = new System.Drawing.Size(1627, 689);
            this.dataGridTransactionHistory.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.Controls.Add(this.dataGridSuppliers);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1645, 705);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Данные о поставщиках";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridSuppliers
            // 
            this.dataGridSuppliers.AllowUserToAddRows = false;
            this.dataGridSuppliers.AllowUserToDeleteRows = false;
            this.dataGridSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuppliers.Location = new System.Drawing.Point(8, 7);
            this.dataGridSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridSuppliers.MultiSelect = false;
            this.dataGridSuppliers.Name = "dataGridSuppliers";
            this.dataGridSuppliers.ReadOnly = true;
            this.dataGridSuppliers.RowHeadersWidth = 51;
            this.dataGridSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuppliers.Size = new System.Drawing.Size(1627, 694);
            this.dataGridSuppliers.TabIndex = 1;
            // 
            // buttonRefreshData
            // 
            this.buttonRefreshData.Location = new System.Drawing.Point(1150, 26);
            this.buttonRefreshData.Name = "buttonRefreshData";
            this.buttonRefreshData.Size = new System.Drawing.Size(248, 66);
            this.buttonRefreshData.TabIndex = 4;
            this.buttonRefreshData.Text = "Обновить данные";
            this.buttonRefreshData.UseVisualStyleBackColor = true;
            this.buttonRefreshData.Click += new System.EventHandler(this.buttonRefreshData_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1414, 26);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(248, 66);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выйти из личного кабинета";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.buttonRefreshData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirmForm";
            this.Text = "Личный кабинет фирмы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCurrentOrders)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactionHistory)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuppliers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonOrderProduct;
        private System.Windows.Forms.DataGridView dataGridProductList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonConfirmOrderProcessComplete;
        private System.Windows.Forms.DataGridView dataGridCurrentOrders;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridTransactionHistory;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonRecallOrder;
        private System.Windows.Forms.DataGridView dataGridSuppliers;
        private System.Windows.Forms.Button buttonRefreshData;
        private System.Windows.Forms.Button buttonExit;
    }
}