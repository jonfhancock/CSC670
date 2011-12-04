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
    public partial class AddEmpForm : Form
    {
        public AddEmpForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            String connectionString = "Data Source=localhost;Initial Catalog=POS;Persist Security Info=True;User ID=dbapp;Password=mar";

            SqlConnection connection =
                       new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "Proc_AddNewEmployee", connection);

                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.Add(
                  new SqlParameter("@@fname", empNameAnsTextBox.Text));
                cmd.Parameters.Add(
                  new SqlParameter("@@lname", emplnameTextBox.Text));
                cmd.Parameters.Add(
                  new SqlParameter("@@eid", empIDTextBox.Text));
                cmd.Parameters.Add(
                  new SqlParameter("@@hdate", hiredateTimePicker.Text));
                cmd.Parameters.Add(
                  new SqlParameter("@@address", empAddressTextBox.Text));

                cmd.ExecuteNonQuery();
                connection.Close();

                this.Close();

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("The system was not able to add \nthe new employee.",
                                "New employee were not Inserted", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();
            }
        }
    }
}
