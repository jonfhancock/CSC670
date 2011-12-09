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
    /// Allows the addition of Customer information
    /// </summary>
    public partial class AddCustForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public AddCustForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User selected to save this information about a new customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            //Verify Names and ID are not blank; Address OK if blank
            if ((customerIDTextBox.Text != string.Empty) &&
                (custFnameTextBox.Text != string.Empty) &&
                (custLnameTextBox.Text != string.Empty))
            {

                SqlConnection connection =
                           new SqlConnection(Program.CONNECTION_STRING);

                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(
                        "Proc_AddNewCustomer", connection);

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(
                      new SqlParameter("@@cid", customerIDTextBox.Text));
                    cmd.Parameters.Add(
                      new SqlParameter("@@fname", custFnameTextBox.Text));
                    cmd.Parameters.Add(
                      new SqlParameter("@@lname", custLnameTextBox.Text));
                    cmd.Parameters.Add(
                      new SqlParameter("@@address", custAddressTextBox.Text));

                    cmd.ExecuteNonQuery();
                    connection.Close();

                    this.Close();

                }
                catch (Exception)
                {
                    connection.Close();
                    MessageBox.Show("The system was not able to add \nthe new items for sale.",
                                    "New products were not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("The Customer ID and Names must be entered.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
