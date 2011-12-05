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
    public partial class AddCustomersForm : Form
    {
        public AddCustomersForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            SqlConnection connection =
                       new SqlConnection(Program.CONNECTION_STRING);

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "Proc_AddNewProduct", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                int iqty = (int)Convert.ToInt32(qtyentrytextBox.Text);
                decimal dPrice = Convert.ToDecimal(priceTextBox.Text);

                cmd.Parameters.Add(
                  new SqlParameter("@@pid", productIdtextBox.Text));
                cmd.Parameters.Add(
                  new SqlParameter("@@pdescript", iDescTextBox.Text));
                cmd.Parameters.Add(
                  new SqlParameter("@@price", dPrice));
                cmd.Parameters.Add(
                  new SqlParameter("@@pqtyonhand", iqty));

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
