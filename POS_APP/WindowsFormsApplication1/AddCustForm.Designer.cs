namespace WindowsFormsApplication1
{
    partial class AddCustForm
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
            this.custAddressTextBox = new System.Windows.Forms.TextBox();
            this.custIdLabel = new System.Windows.Forms.Label();
            this.custLnameTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.custNameLabel = new System.Windows.Forms.Label();
            this.custAddressLabel = new System.Windows.Forms.Label();
            this.custFnameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // custAddressTextBox
            // 
            this.custAddressTextBox.Location = new System.Drawing.Point(53, 91);
            this.custAddressTextBox.Name = "custAddressTextBox";
            this.custAddressTextBox.Size = new System.Drawing.Size(500, 20);
            this.custAddressTextBox.TabIndex = 4;
            // 
            // custIdLabel
            // 
            this.custIdLabel.AutoSize = true;
            this.custIdLabel.Location = new System.Drawing.Point(26, 15);
            this.custIdLabel.Name = "custIdLabel";
            this.custIdLabel.Size = new System.Drawing.Size(21, 13);
            this.custIdLabel.TabIndex = 12;
            this.custIdLabel.Text = "ID:";
            // 
            // custLnameTextBox
            // 
            this.custLnameTextBox.Location = new System.Drawing.Point(205, 48);
            this.custLnameTextBox.Name = "custLnameTextBox";
            this.custLnameTextBox.Size = new System.Drawing.Size(182, 20);
            this.custLnameTextBox.TabIndex = 3;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(53, 12);
            this.customerIDTextBox.MaxLength = 7;
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.customerIDTextBox.TabIndex = 1;
            // 
            // custNameLabel
            // 
            this.custNameLabel.AutoSize = true;
            this.custNameLabel.Location = new System.Drawing.Point(32, 53);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Size = new System.Drawing.Size(38, 13);
            this.custNameLabel.TabIndex = 13;
            this.custNameLabel.Text = "Name:";
            // 
            // custAddressLabel
            // 
            this.custAddressLabel.AutoSize = true;
            this.custAddressLabel.Location = new System.Drawing.Point(8, 94);
            this.custAddressLabel.Name = "custAddressLabel";
            this.custAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.custAddressLabel.TabIndex = 15;
            this.custAddressLabel.Text = "Address:";
            // 
            // custFnameTextBox
            // 
            this.custFnameTextBox.Location = new System.Drawing.Point(76, 48);
            this.custFnameTextBox.Name = "custFnameTextBox";
            this.custFnameTextBox.Size = new System.Drawing.Size(98, 20);
            this.custFnameTextBox.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(255, 153);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Add";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AddCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 188);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.custAddressTextBox);
            this.Controls.Add(this.custIdLabel);
            this.Controls.Add(this.custLnameTextBox);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.custAddressLabel);
            this.Controls.Add(this.custFnameTextBox);
            this.Name = "AddCustForm";
            this.Text = "Add Customers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox custAddressTextBox;
        private System.Windows.Forms.Label custIdLabel;
        private System.Windows.Forms.TextBox custLnameTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Label custNameLabel;
        private System.Windows.Forms.Label custAddressLabel;
        private System.Windows.Forms.TextBox custFnameTextBox;
        private System.Windows.Forms.Button okButton;
    }
}