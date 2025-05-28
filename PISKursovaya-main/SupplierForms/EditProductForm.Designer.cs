namespace PISKursovaya
{
    partial class EditProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxIsOnSale = new System.Windows.Forms.CheckBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.numericCost = new System.Windows.Forms.NumericUpDown();
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редактирование запчасти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            // 
            // checkBoxIsOnSale
            // 
            this.checkBoxIsOnSale.AutoSize = true;
            this.checkBoxIsOnSale.Location = new System.Drawing.Point(483, 266);
            this.checkBoxIsOnSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxIsOnSale.Name = "checkBoxIsOnSale";
            this.checkBoxIsOnSale.Size = new System.Drawing.Size(107, 20);
            this.checkBoxIsOnSale.TabIndex = 8;
            this.checkBoxIsOnSale.Text = "На продаже";
            this.checkBoxIsOnSale.UseVisualStyleBackColor = true;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(236, 305);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(284, 47);
            this.buttonSaveChanges.TabIndex = 9;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(236, 370);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(284, 47);
            this.buttonDeleteProduct.TabIndex = 10;
            this.buttonDeleteProduct.Text = "Удалить запчасть";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // numericCost
            // 
            this.numericCost.Location = new System.Drawing.Point(165, 214);
            this.numericCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericCost.Name = "numericCost";
            this.numericCost.Size = new System.Drawing.Size(433, 22);
            this.numericCost.TabIndex = 11;
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(165, 86);
            this.textBoxArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.ReadOnly = true;
            this.textBoxArticle.Size = new System.Drawing.Size(432, 22);
            this.textBoxArticle.TabIndex = 12;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 149);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(432, 22);
            this.textBoxName.TabIndex = 13;
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 465);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxArticle);
            this.Controls.Add(this.numericCost);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.checkBoxIsOnSale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditProductForm";
            this.Text = "Редактирование запчасти";
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxIsOnSale;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.NumericUpDown numericCost;
        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.TextBox textBoxName;
    }
}