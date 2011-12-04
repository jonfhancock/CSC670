namespace WindowsFormsApplication1
{
    partial class SalesForm 
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
            this.components = new System.ComponentModel.Container();
            this.empIdLabel = new System.Windows.Forms.Label();
            this.procAllEmployeeIdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empNameLabel = new System.Windows.Forms.Label();
            this.empNameAnsTextBox = new System.Windows.Forms.TextBox();
            this.custIdLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.custFnameTextBox = new System.Windows.Forms.TextBox();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custAddressTextBox = new System.Windows.Forms.TextBox();
            this.custAddressLabel = new System.Windows.Forms.Label();
            this.custLnameTextBox = new System.Windows.Forms.TextBox();
            this.emplnameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pricelabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iDescTextBox = new System.Windows.Forms.TextBox();
            this.itemsListView = new System.Windows.Forms.ListView();
            this.icolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddItemButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.itemEntryTextBox = new System.Windows.Forms.TextBox();
            this.qtyentrytextBox = new System.Windows.Forms.TextBox();
            this.ItemIDLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.payComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // empIdLabel
            // 
            this.empIdLabel.AutoSize = true;
            this.empIdLabel.Location = new System.Drawing.Point(22, 25);
            this.empIdLabel.Name = "empIdLabel";
            this.empIdLabel.Size = new System.Drawing.Size(21, 13);
            this.empIdLabel.TabIndex = 0;
            this.empIdLabel.Text = "ID:";
            //
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(196, 24);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(38, 13);
            this.empNameLabel.TabIndex = 2;
            this.empNameLabel.Text = "Name:";
            // 
            // empNameAnsTextBox
            // 
            this.empNameAnsTextBox.Enabled = false;
            this.empNameAnsTextBox.Location = new System.Drawing.Point(240, 22);
            this.empNameAnsTextBox.Name = "empNameAnsTextBox";
            this.empNameAnsTextBox.Size = new System.Drawing.Size(113, 20);
            this.empNameAnsTextBox.TabIndex = 3;
            this.empNameAnsTextBox.TabStop = false;
            // 
            // custIdLabel
            // 
            this.custIdLabel.AutoSize = true;
            this.custIdLabel.Location = new System.Drawing.Point(21, 29);
            this.custIdLabel.Name = "custIdLabel";
            this.custIdLabel.Size = new System.Drawing.Size(21, 13);
            this.custIdLabel.TabIndex = 4;
            this.custIdLabel.Text = "ID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(48, 26);
            this.customerIDTextBox.MaxLength = 7;
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.customerIDTextBox.TabIndex = 2;
            this.customerIDTextBox.Leave += new System.EventHandler(this.customerIDTextBox_TextLeave);
            // 
            // custFnameTextBox
            // 
            this.custFnameTextBox.Enabled = false;
            this.custFnameTextBox.Location = new System.Drawing.Point(240, 24);
            this.custFnameTextBox.Name = "custFnameTextBox";
            this.custFnameTextBox.Size = new System.Drawing.Size(98, 20);
            this.custFnameTextBox.TabIndex = 7;
            this.custFnameTextBox.TabStop = false;
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(196, 29);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(38, 13);
            this.custNameLabel.TabIndex = 6;
            this.custNameLabel.Text = "Name:";
            // 
            // custAddressTextBox
            // 
            this.custAddressTextBox.Enabled = false;
            this.custAddressTextBox.Location = new System.Drawing.Point(51, 63);
            this.custAddressTextBox.Name = "custAddressTextBox";
            this.custAddressTextBox.Size = new System.Drawing.Size(500, 20);
            this.custAddressTextBox.TabIndex = 9;
            this.custAddressTextBox.TabStop = false;
            // 
            // custAddressLabel
            // 
            this.custAddressLabel.AutoSize = true;
            this.custAddressLabel.Location = new System.Drawing.Point(6, 66);
            this.custAddressLabel.Name = "custAddressLabel";
            this.custAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.custAddressLabel.TabIndex = 8;
            this.custAddressLabel.Text = "Address:";
            // 
            // 
            // custLnameTextBox
            // 
            this.custLnameTextBox.Enabled = false;
            this.custLnameTextBox.Location = new System.Drawing.Point(369, 22);
            this.custLnameTextBox.Name = "custLnameTextBox";
            this.custLnameTextBox.Size = new System.Drawing.Size(182, 20);
            this.custLnameTextBox.TabIndex = 10;
            this.custLnameTextBox.TabStop = false;
            // 
            // emplnameTextBox
            // 
            this.emplnameTextBox.Enabled = false;
            this.emplnameTextBox.Location = new System.Drawing.Point(369, 20);
            this.emplnameTextBox.Name = "emplnameTextBox";
            this.emplnameTextBox.Size = new System.Drawing.Size(182, 20);
            this.emplnameTextBox.TabIndex = 11;
            this.emplnameTextBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empIDTextBox);
            this.groupBox1.Controls.Add(this.emplnameTextBox);
            this.groupBox1.Controls.Add(this.empNameAnsTextBox);
            this.groupBox1.Controls.Add(this.empNameLabel);
            this.groupBox1.Controls.Add(this.empIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(51, 21);
            this.empIDTextBox.MaxLength = 3;
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.empIDTextBox.TabIndex = 1;
            this.empIDTextBox.Leave += new System.EventHandler(this.empIDTextBox_TextLeave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.custAddressTextBox);
            this.groupBox2.Controls.Add(this.custIdLabel);
            this.groupBox2.Controls.Add(this.custLnameTextBox);
            this.groupBox2.Controls.Add(this.customerIDTextBox);
            this.groupBox2.Controls.Add(this.custNameLabel);
            this.groupBox2.Controls.Add(this.custAddressLabel);
            this.groupBox2.Controls.Add(this.custFnameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(16, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 111);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pricelabel);
            this.groupBox3.Controls.Add(this.priceTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.iDescTextBox);
            this.groupBox3.Controls.Add(this.itemsListView);
            this.groupBox3.Controls.Add(this.AddItemButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.itemEntryTextBox);
            this.groupBox3.Controls.Add(this.qtyentrytextBox);
            this.groupBox3.Controls.Add(this.ItemIDLabel);
            this.groupBox3.Location = new System.Drawing.Point(16, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 229);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(353, 24);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(34, 13);
            this.pricelabel.TabIndex = 23;
            this.pricelabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(393, 21);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(68, 20);
            this.priceTextBox.TabIndex = 22;
            this.priceTextBox.TabStop = false;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Description:";
            // 
            // iDescTextBox
            // 
            this.iDescTextBox.Enabled = false;
            this.iDescTextBox.Location = new System.Drawing.Point(162, 21);
            this.iDescTextBox.Name = "iDescTextBox";
            this.iDescTextBox.Size = new System.Drawing.Size(187, 20);
            this.iDescTextBox.TabIndex = 20;
            this.iDescTextBox.TabStop = false;
            // 
            // itemsListView
            // 
            this.itemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.icolumnHeader,
            this.dcolumnHeader,
            this.pcolumnHeader,
            this.qcolumnHeader,
            this.tcolumnHeader});
            this.itemsListView.FullRowSelect = true;
            this.itemsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemsListView.Location = new System.Drawing.Point(9, 70);
            this.itemsListView.Name = "itemsListView";
            this.itemsListView.Size = new System.Drawing.Size(542, 151);
            this.itemsListView.TabIndex = 0;
            this.itemsListView.TabStop = false;
            this.itemsListView.UseCompatibleStateImageBehavior = false;
            this.itemsListView.View = System.Windows.Forms.View.Details;
            // 
            // icolumnHeader
            // 
            this.icolumnHeader.Text = "Item";
            this.icolumnHeader.Width = 66;
            // 
            // dcolumnHeader
            // 
            this.dcolumnHeader.Text = "Description";
            this.dcolumnHeader.Width = 275;
            // 
            // pcolumnHeader
            // 
            this.pcolumnHeader.Text = "Price";
            this.pcolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // qcolumnHeader
            // 
            this.qcolumnHeader.Text = "Quantity";
            this.qcolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tcolumnHeader
            // 
            this.tcolumnHeader.Text = "Total";
            this.tcolumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Location = new System.Drawing.Point(243, 41);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(75, 23);
            this.AddItemButton.TabIndex = 5;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quantity:";
            // 
            // itemEntryTextBox
            // 
            this.itemEntryTextBox.Location = new System.Drawing.Point(31, 22);
            this.itemEntryTextBox.MaxLength = 10;
            this.itemEntryTextBox.Name = "itemEntryTextBox";
            this.itemEntryTextBox.Size = new System.Drawing.Size(60, 20);
            this.itemEntryTextBox.TabIndex = 3;
            this.itemEntryTextBox.Leave += new System.EventHandler(this.itemEntryTextBox_TextLeave);
            // 
            // qtyentrytextBox
            // 
            this.qtyentrytextBox.Location = new System.Drawing.Point(512, 21);
            this.qtyentrytextBox.MaxLength = 999;
            this.qtyentrytextBox.Name = "qtyentrytextBox";
            this.qtyentrytextBox.Size = new System.Drawing.Size(42, 20);
            this.qtyentrytextBox.TabIndex = 4;
            this.qtyentrytextBox.Text = "1";
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Location = new System.Drawing.Point(8, 24);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(21, 13);
            this.ItemIDLabel.TabIndex = 17;
            this.ItemIDLabel.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.payComboBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TotalTextBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.taxTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.subTotalTextBox);
            this.groupBox4.Controls.Add(this.SubTotalLabel);
            this.groupBox4.Location = new System.Drawing.Point(16, 448);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 116);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sale";
            // 
            // payComboBox
            // 
            this.payComboBox.FormattingEnabled = true;
            this.payComboBox.Location = new System.Drawing.Point(355, 25);
            this.payComboBox.Name = "payComboBox";
            this.payComboBox.Size = new System.Drawing.Size(121, 21);
            this.payComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Payment Type:";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Enabled = false;
            this.TotalTextBox.Location = new System.Drawing.Point(355, 52);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(121, 20);
            this.TotalTextBox.TabIndex = 9;
            this.TotalTextBox.TabStop = false;
            this.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // taxTextBox
            // 
            this.taxTextBox.Enabled = false;
            this.taxTextBox.Location = new System.Drawing.Point(103, 54);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(113, 20);
            this.taxTextBox.TabIndex = 7;
            this.taxTextBox.TabStop = false;
            this.taxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tax:";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Enabled = false;
            this.subTotalTextBox.Location = new System.Drawing.Point(103, 28);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(113, 20);
            this.subTotalTextBox.TabIndex = 5;
            this.subTotalTextBox.TabStop = false;
            this.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Location = new System.Drawing.Point(46, 30);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.SubTotalLabel.TabIndex = 4;
            this.SubTotalLabel.Text = "Sub-Total:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(204, 571);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(318, 570);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 609);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SalesForm";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label empIdLabel;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.TextBox empNameAnsTextBox;
        private System.Windows.Forms.Label custIdLabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox custFnameTextBox;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.TextBox custAddressTextBox;
        private System.Windows.Forms.Label custAddressLabel;
        private System.Windows.Forms.BindingSource procAllEmployeeIdsBindingSource;
        private System.Windows.Forms.TextBox custLnameTextBox;
        private System.Windows.Forms.TextBox emplnameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox itemEntryTextBox;
        private System.Windows.Forms.Label ItemIDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtyentrytextBox;
        private System.Windows.Forms.ComboBox payComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView itemsListView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox iDescTextBox;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ColumnHeader icolumnHeader;
        private System.Windows.Forms.ColumnHeader dcolumnHeader;
        private System.Windows.Forms.ColumnHeader pcolumnHeader;
        private System.Windows.Forms.ColumnHeader qcolumnHeader;
        private System.Windows.Forms.ColumnHeader tcolumnHeader;
    }
}