namespace WindowsFormsApplication1
{
    partial class AddProductsForm
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
            this.pricelabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.iDescTextBox = new System.Windows.Forms.TextBox();
            this.qtyLabel = new System.Windows.Forms.Label();
            this.qtyentrytextBox = new System.Windows.Forms.TextBox();
            this.ItemIDLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.productIdtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(14, 91);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(34, 13);
            this.pricelabel.TabIndex = 31;
            this.pricelabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(52, 88);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(68, 20);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(14, 54);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(63, 13);
            this.descLabel.TabIndex = 29;
            this.descLabel.Text = "Description:";
            // 
            // iDescTextBox
            // 
            this.iDescTextBox.Location = new System.Drawing.Point(77, 51);
            this.iDescTextBox.Name = "iDescTextBox";
            this.iDescTextBox.Size = new System.Drawing.Size(187, 20);
            this.iDescTextBox.TabIndex = 2;
            // 
            // qtyLabel
            // 
            this.qtyLabel.AutoSize = true;
            this.qtyLabel.Location = new System.Drawing.Point(167, 91);
            this.qtyLabel.Name = "qtyLabel";
            this.qtyLabel.Size = new System.Drawing.Size(49, 13);
            this.qtyLabel.TabIndex = 27;
            this.qtyLabel.Text = "Quantity:";
            // 
            // qtyentrytextBox
            // 
            this.qtyentrytextBox.Location = new System.Drawing.Point(222, 88);
            this.qtyentrytextBox.MaxLength = 999;
            this.qtyentrytextBox.Name = "qtyentrytextBox";
            this.qtyentrytextBox.Size = new System.Drawing.Size(42, 20);
            this.qtyentrytextBox.TabIndex = 4;
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(14, 18);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(21, 13);
            this.ItemIDLabel.TabIndex = 26;
            this.ItemIDLabel.Text = "ID:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(115, 145);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productIdtextBox
            // 
            this.productIdtextBox.Location = new System.Drawing.Point(41, 15);
            this.productIdtextBox.Name = "productIdtextBox";
            this.productIdtextBox.Size = new System.Drawing.Size(79, 20);
            this.productIdtextBox.TabIndex = 1;
            this.productIdtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 180);
            this.Controls.Add(this.productIdtextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pricelabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.iDescTextBox);
            this.Controls.Add(this.qtyLabel);
            this.Controls.Add(this.qtyentrytextBox);
            this.Controls.Add(this.ItemIDLabel);
            this.Name = "AddProductsForm";
            this.Text = "Add Products ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox iDescTextBox;
        private System.Windows.Forms.Label qtyLabel;
        private System.Windows.Forms.TextBox qtyentrytextBox;
        private System.Windows.Forms.Label ItemIDLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox productIdtextBox;
    }
}