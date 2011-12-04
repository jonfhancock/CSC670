namespace WindowsFormsApplication1
{
    partial class ProductsListForm
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
            this.productListHeaderlabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescptioncolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QtycolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pricecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productListHeaderlabel
            // 
            this.productListHeaderlabel.AutoSize = true;
            this.productListHeaderlabel.Location = new System.Drawing.Point(13, 13);
            this.productListHeaderlabel.Name = "productListHeaderlabel";
            this.productListHeaderlabel.Size = new System.Drawing.Size(155, 13);
            this.productListHeaderlabel.TabIndex = 0;
            this.productListHeaderlabel.Text = "List of all the available products";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(207, 522);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcolumnHeader,
            this.DescptioncolumnHeader,
            this.QtycolumnHeader,
            this.pricecolumnHeader});
            this.listView1.Location = new System.Drawing.Point(16, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(470, 463);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idcolumnHeader
            // 
            this.idcolumnHeader.Text = "ID";
            // 
            // DescptioncolumnHeader
            // 
            this.DescptioncolumnHeader.Text = "Description";
            this.DescptioncolumnHeader.Width = 220;
            // 
            // QtycolumnHeader
            // 
            this.QtycolumnHeader.Text = "Quantity";
            this.QtycolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pricecolumnHeader
            // 
            this.pricecolumnHeader.Text = "Price";
            this.pricecolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(253, 7);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(60, 25);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // ProductsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 557);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.productListHeaderlabel);
            this.Name = "ProductsListForm";
            this.Text = "Products List";
            this.Load += new System.EventHandler(this.ProductsListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productListHeaderlabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idcolumnHeader;
        private System.Windows.Forms.ColumnHeader DescptioncolumnHeader;
        private System.Windows.Forms.ColumnHeader QtycolumnHeader;
        private System.Windows.Forms.ColumnHeader pricecolumnHeader;
        private System.Windows.Forms.Button addbutton;
    }
}