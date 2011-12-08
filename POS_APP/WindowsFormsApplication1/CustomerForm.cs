using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace WindowsFormsApplication1
{
    /// <summary>
    /// A display of all the cusotmers that are known to the system
    /// </summary>
    public partial class CustomerForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CustomerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The user selected to close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// On intializing the form the list view need to be setup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            setupListView();
        }

        /// <summary>
        /// Gather the customer data from the DB to put in the list view
        /// </summary>
        private void setupListView()
        {

            SqlConnection connection =
                       new SqlConnection(Program.CONNECTION_STRING);

            SqlDataReader rdr = null;
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "Proc_AllCustomerList", connection);

                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string[] sitems = (new string[]
                    {
                        rdr["custid"].ToString(),
                        rdr["fname"].ToString(),
                        rdr["lname"].ToString(),
                        rdr["address"].ToString()
                    });

                    ListViewItem lvi = new ListViewItem(sitems);
                    this.custListView.Items.Add(lvi);
                }

                rdr.Close();
            }

            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("The system was not able to retrieve \nthe list of customers.",
                                "Customers were not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();
            }

        }

        /// <summary>
        /// The  user desires to add a new customer.  
        /// This will launch the new customer Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddCustForm ac = new AddCustForm();
            ac.Show();
        }


    }
}
