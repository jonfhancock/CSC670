using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Allows for the adding of an employee
    /// </summary>
    public partial class AddEmpForm : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public AddEmpForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User selected to save this information about a new Employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {

            //Verify Names and ID are not blank; Default hire date is given by the form
            if ((empIDTextBox.Text != string.Empty) &&
                (empNameAnsTextBox.Text != string.Empty) &&
                (emplnameTextBox.Text != string.Empty))
            {
                SqlConnection connection =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

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
                catch (Exception)
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
            else
            {
                MessageBox.Show("The employee ID and Names must be entered.", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
