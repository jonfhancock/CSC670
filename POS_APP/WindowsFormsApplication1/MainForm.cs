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
    /// <summary>
    /// This window controls the navigation in the system
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Launches the Employee infomration path of the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeeButton_Click(object sender, EventArgs e)
        {
            EmployeeForm elist = new EmployeeForm();
            elist.Show();

        }

        /// <summary>
        /// Launches the sale transaction path of the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaleButton_Click(object sender, EventArgs e)
        {
            SalesForm sf = new SalesForm();
            sf.Show();
        }

        /// <summary>
        /// Launches the Customer infomration path of the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerButton_Click(object sender, EventArgs e)
        {
            CustomerForm cf = new CustomerForm();
            cf.Show();
        }

        /// <summary>
        /// Launches the Product infomration path of the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsListForm pf = new ProductsListForm();
            pf.Show();
        }
        
    }
}
