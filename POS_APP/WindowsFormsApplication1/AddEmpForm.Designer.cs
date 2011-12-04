namespace WindowsFormsApplication1
{
    partial class AddEmpForm
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
            this.empIDTextBox = new System.Windows.Forms.TextBox();
            this.emplnameTextBox = new System.Windows.Forms.TextBox();
            this.empNameAnsTextBox = new System.Windows.Forms.TextBox();
            this.empNameLabel = new System.Windows.Forms.Label();
            this.empIdLabel = new System.Windows.Forms.Label();
            this.empAddressTextBox = new System.Windows.Forms.TextBox();
            this.custAddressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hiredateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // empIDTextBox
            // 
            this.empIDTextBox.Location = new System.Drawing.Point(44, 21);
            this.empIDTextBox.MaxLength = 3;
            this.empIDTextBox.Name = "empIDTextBox";
            this.empIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.empIDTextBox.TabIndex = 1;
            // 
            // emplnameTextBox
            // 
            this.emplnameTextBox.Location = new System.Drawing.Point(190, 58);
            this.emplnameTextBox.Name = "emplnameTextBox";
            this.emplnameTextBox.Size = new System.Drawing.Size(182, 20);
            this.emplnameTextBox.TabIndex = 3;
            // 
            // empNameAnsTextBox
            // 
            this.empNameAnsTextBox.Location = new System.Drawing.Point(61, 60);
            this.empNameAnsTextBox.Name = "empNameAnsTextBox";
            this.empNameAnsTextBox.Size = new System.Drawing.Size(113, 20);
            this.empNameAnsTextBox.TabIndex = 2;
            // 
            // empNameLabel
            // 
            this.empNameLabel.AutoSize = true;
            this.empNameLabel.Location = new System.Drawing.Point(17, 62);
            this.empNameLabel.Name = "empNameLabel";
            this.empNameLabel.Size = new System.Drawing.Size(38, 13);
            this.empNameLabel.TabIndex = 14;
            this.empNameLabel.Text = "Name:";
            // 
            // empIdLabel
            // 
            this.empIdLabel.AutoSize = true;
            this.empIdLabel.Location = new System.Drawing.Point(15, 25);
            this.empIdLabel.Name = "empIdLabel";
            this.empIdLabel.Size = new System.Drawing.Size(21, 13);
            this.empIdLabel.TabIndex = 12;
            this.empIdLabel.Text = "ID:";
            // 
            // empAddressTextBox
            // 
            this.empAddressTextBox.Location = new System.Drawing.Point(61, 100);
            this.empAddressTextBox.Name = "empAddressTextBox";
            this.empAddressTextBox.Size = new System.Drawing.Size(500, 20);
            this.empAddressTextBox.TabIndex = 4;
            // 
            // custAddressLabel
            // 
            this.custAddressLabel.AutoSize = true;
            this.custAddressLabel.Location = new System.Drawing.Point(16, 103);
            this.custAddressLabel.Name = "custAddressLabel";
            this.custAddressLabel.Size = new System.Drawing.Size(48, 13);
            this.custAddressLabel.TabIndex = 18;
            this.custAddressLabel.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hire Date:";
            // 
            // hiredateTimePicker
            // 
            this.hiredateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.hiredateTimePicker.Location = new System.Drawing.Point(79, 145);
            this.hiredateTimePicker.Name = "hiredateTimePicker";
            this.hiredateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.hiredateTimePicker.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(248, 180);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 215);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.hiredateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empAddressTextBox);
            this.Controls.Add(this.custAddressLabel);
            this.Controls.Add(this.empIDTextBox);
            this.Controls.Add(this.emplnameTextBox);
            this.Controls.Add(this.empNameAnsTextBox);
            this.Controls.Add(this.empNameLabel);
            this.Controls.Add(this.empIdLabel);
            this.Name = "AddEmpForm";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox empIDTextBox;
        private System.Windows.Forms.TextBox emplnameTextBox;
        private System.Windows.Forms.TextBox empNameAnsTextBox;
        private System.Windows.Forms.Label empNameLabel;
        private System.Windows.Forms.Label empIdLabel;
        private System.Windows.Forms.TextBox empAddressTextBox;
        private System.Windows.Forms.Label custAddressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker hiredateTimePicker;
        private System.Windows.Forms.Button AddButton;
    }
}