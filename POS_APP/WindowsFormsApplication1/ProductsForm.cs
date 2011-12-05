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
    public partial class ProductsListForm : Form
    {
        public ProductsListForm()
        {
            InitializeComponent();
        }

        private void ProductsListForm_Load(object sender, EventArgs e)
        {

            setupListView();
        }

        private void setupListView()
        {
           
            String connectionString = "Data Source=localhost;Initial Catalog=POS;Persist Security Info=True;User ID=dbapp;Password=mar";

            SqlConnection connection =
                       new SqlConnection(connectionString);

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

            catch (Exception ex)
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
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            AddCustomersForm ap = new AddCustomersForm();
            ap.Show();
        }
    }
}
