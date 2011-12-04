namespace WindowsFormsApplication1
{
    partial class EmployeeForm
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
            this.EmpHeaderLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.idcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fnamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnamecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addresscolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdatecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tdatecolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmpHeaderLabel
            // 
            this.EmpHeaderLabel.AutoSize = true;
            this.EmpHeaderLabel.Location = new System.Drawing.Point(24, 13);
            this.EmpHeaderLabel.Name = "EmpHeaderLabel";
            this.EmpHeaderLabel.Size = new System.Drawing.Size(157, 13);
            this.EmpHeaderLabel.TabIndex = 0;
            this.EmpHeaderLabel.Text = "This is a list of all the employees";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(369, 413);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcolumnHeader,
            this.fnamecolumnHeader,
            this.lnamecolumnHeader,
            this.addresscolumnHeader,
            this.hdatecolumnHeader,
            this.tdatecolumnHeader});
            this.listView1.Location = new System.Drawing.Point(27, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(768, 346);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // idcolumnHeader
            // 
            this.idcolumnHeader.Text = "ID";
            // 
            // fnamecolumnHeader
            // 
            this.fnamecolumnHeader.Text = "First Name";
            this.fnamecolumnHeader.Width = 100;
            // 
            // lnamecolumnHeader
            // 
            this.lnamecolumnHeader.Text = "Last Name";
            this.lnamecolumnHeader.Width = 120;
            // 
            // addresscolumnHeader
            // 
            this.addresscolumnHeader.Text = "Address";
            this.addresscolumnHeader.Width = 250;
            // 
            // hdatecolumnHeader
            // 
            this.hdatecolumnHeader.Text = "Hire Date";
            this.hdatecolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hdatecolumnHeader.Width = 100;
            // 
            // tdatecolumnHeader
            // 
            this.tdatecolumnHeader.Text = "Term Date";
            this.tdatecolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tdatecolumnHeader.Width = 100;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(414, 13);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 448);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.EmpHeaderLabel);
            this.Name = "EmployeeForm";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmpHeaderLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idcolumnHeader;
        private System.Windows.Forms.ColumnHeader fnamecolumnHeader;
        private System.Windows.Forms.ColumnHeader lnamecolumnHeader;
        private System.Windows.Forms.ColumnHeader addresscolumnHeader;
        private System.Windows.Forms.ColumnHeader hdatecolumnHeader;
        private System.Windows.Forms.ColumnHeader tdatecolumnHeader;
        private System.Windows.Forms.Button addButton;
    }
}