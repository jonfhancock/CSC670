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
    public partial class AddCustForm : Form
    {
        public AddCustForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            String connectionString = "Data Source=localhost;Initial Catalog=POS;Persist Security Info=True;User ID=dbapp;Password=mar";

            SqlConnection connection =
                       new SqlConnection(connectionString);

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
            catch (Exception ex)
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
    }
}
