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
    /// A display of all the employees that are known to the system
    /// </summary>
    public partial class EmployeeForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EmployeeForm()
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
        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            
            setupListView();

        }

        /// <summary>
        /// Gather the customer data from the DB to put in the list view
        /// </summary>
        private void setupListView()
        {

            SqlConnection connection =
                       new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

            SqlDataReader rdr = null;
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "Proc_AllEmployeeList", connection);

                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string[] sitems = (new string[]
                    {
                        rdr["eid"].ToString(),
                        rdr["fname"].ToString(),
                        rdr["lname"].ToString(),
                        rdr["address"].ToString(),
                        rdr["hdate"].ToString(),
                        rdr["tdate"].ToString()
                    });

                    ListViewItem lvi = new ListViewItem(sitems);
                    this.empListView.Items.Add(lvi);
                }

                rdr.Close();
            }

            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("The system was not able to retrieve \nthe list of employees.",
                                "Employees were not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();
            }

        }
        /// <summary>
        /// The  user desires to add a new employee.  
        /// This will launch the new employee Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmpForm ae = new AddEmpForm();
            ae.Show();
        }
    }
}
