using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm elist = new EmployeeForm();
            elist.Show();

        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.Show();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm();
            cf.Show();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsListForm pf = new ProductsListForm();
            pf.Show();
        }
        
    }
}
