using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace WindowsFormsApplication1
{
    /// <summary>
    /// A display of all the products that are known to the system
    /// </summary>
    public partial class ProductsListForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ProductsListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On intializing the form the list view need to be setup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsListForm_Load(object sender, EventArgs e)
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

            SqlDataReader rdr  = null;
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "Proc_ShowProductInventory", connection);

                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    string[] sitems = (new string[]
                    {
                        rdr["pid"].ToString(),
                        rdr["pdescript"].ToString(),
                        rdr["pqtyonhand"].ToString(),
                        rdr["price"].ToString()
                    });

                    ListViewItem lvi = new ListViewItem(sitems);
                    this.prodListView.Items.Add(lvi);
                }

                rdr.Close();
            }

            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("The system was not able to retrieve \nthe list of products for sale.",
                                "Products were not found", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// The user selected to close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// The  user desires to add a new product.  
        /// This will launch the new product Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addbutton_Click(object sender, EventArgs e)
        {
            AddProductsForm ap = new AddProductsForm();
            ap.Show();
        }
    }
}
