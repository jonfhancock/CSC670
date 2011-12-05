namespace WindowsFormsApplication1
{
    partial class CustomerForm
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
            this.formDescLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.custListView = new System.Windows.Forms.ListView();
            this.idcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fnamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addresscolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formDescLabel
            // 
            this.formDescLabel.AutoSize = true;
            this.formDescLabel.Location = new System.Drawing.Point(34, 13);
            this.formDescLabel.Name = "formDescLabel";
            this.formDescLabel.Size = new System.Drawing.Size(181, 13);
            this.formDescLabel.TabIndex = 1;
            this.formDescLabel.Text = "This shows a list of all the customers.";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(304, 488);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // custListView
            // 
            this.custListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcolumnHeader,
            this.fnamecolumnHeader,
            this.lnamecolumnHeader,
            this.addresscolumnHeader});
            this.custListView.Location = new System.Drawing.Point(29, 40);
            this.custListView.Name = "custListView";
            this.custListView.Size = new System.Drawing.Size(638, 426);
            this.custListView.TabIndex = 5;
            this.custListView.UseCompatibleStateImageBehavior = false;
            this.custListView.View = System.Windows.Forms.View.Details;
            // 
            // idcolumnHeader
            // 
            this.idcolumnHeader.Text = "ID";
            this.idcolumnHeader.Width = 75;
            // 
            // fnamecolumnHeader
            // 
            this.fnamecolumnHeader.Text = "First Name";
            this.fnamecolumnHeader.Width = 120;
            // 
            // lnamecolumnHeader
            // 
            this.lnamecolumnHeader.Text = "Last Name";
            this.lnamecolumnHeader.Width = 150;
            // 
            // addresscolumnHeader
            // 
            this.addresscolumnHeader.Text = "Address";
            this.addresscolumnHeader.Width = 250;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(390, 8);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 523);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.custListView);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.formDescLabel);
            this.Name = "CustomerForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formDescLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView custListView;
        private System.Windows.Forms.ColumnHeader idcolumnHeader;
        private System.Windows.Forms.ColumnHeader fnamecolumnHeader;
        private System.Windows.Forms.ColumnHeader lnamecolumnHeader;
        private System.Windows.Forms.ColumnHeader addresscolumnHeader;
        private System.Windows.Forms.Button AddButton;

    }
}