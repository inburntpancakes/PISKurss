namespace PISKursovaya.FirmForms
{
    partial class OrderProductForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.buttonOrderProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSupplierId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxOverallCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(161, 122);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(432, 22);
            this.textBoxName.TabIndex = 32;
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(161, 74);
            this.textBoxArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.ReadOnly = true;
            this.textBoxArticle.Size = new System.Drawing.Size(432, 22);
            this.textBoxArticle.TabIndex = 31;
            // 
            // buttonOrderProduct
            // 
            this.buttonOrderProduct.Location = new System.Drawing.Point(241, 370);
            this.buttonOrderProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrderProduct.Name = "buttonOrderProduct";
            this.buttonOrderProduct.Size = new System.Drawing.Size(284, 47);
            this.buttonOrderProduct.TabIndex = 29;
            this.buttonOrderProduct.Text = "Оформить заказ";
            this.buttonOrderProduct.UseVisualStyleBackColor = true;
            this.buttonOrderProduct.Click += new System.EventHandler(this.buttonOrderProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 198);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Цена за елиницу товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Артикул";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Оформление заказа на запчасть";
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(161, 266);
            this.numericQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(433, 22);
            this.numericQuantity.TabIndex = 34;
            this.numericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericQuantity.ValueChanged += new System.EventHandler(this.numericQuantity_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Количество";
            // 
            // textBoxSupplierId
            // 
            this.textBoxSupplierId.Location = new System.Drawing.Point(161, 170);
            this.textBoxSupplierId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSupplierId.Name = "textBoxSupplierId";
            this.textBoxSupplierId.ReadOnly = true;
            this.textBoxSupplierId.Size = new System.Drawing.Size(432, 22);
            this.textBoxSupplierId.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Код поставщика";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Итоговая цена";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(161, 218);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.ReadOnly = true;
            this.textBoxCost.Size = new System.Drawing.Size(432, 22);
            this.textBoxCost.TabIndex = 39;
            // 
            // textBoxOverallCost
            // 
            this.textBoxOverallCost.Location = new System.Drawing.Point(161, 315);
            this.textBoxOverallCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOverallCost.Name = "textBoxOverallCost";
            this.textBoxOverallCost.ReadOnly = true;
            this.textBoxOverallCost.Size = new System.Drawing.Size(432, 22);
            this.textBoxOverallCost.TabIndex = 40;
            // 
            // OrderProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 465);
            this.Controls.Add(this.textBoxOverallCost);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSupplierId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.buttonOrderProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderProductForm";
            this.Text = "Оформление заказа";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.Button buttonOrderProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSupplierId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxOverallCost;
    }
}