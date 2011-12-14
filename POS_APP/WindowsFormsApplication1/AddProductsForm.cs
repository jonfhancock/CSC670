﻿using System;
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
    /// Allows for the addition of new products
    /// </summary>
    public partial class AddProductsForm : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public AddProductsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User selected to save this information about a new product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            //Verify Names and ID are not blank; Default hire date is given by the form
            if ((productIdtextBox.Text != string.Empty) &&
                (iDescTextBox.Text != string.Empty) &&
                (qtyentrytextBox.Text != string.Empty) &&
                (priceTextBox.Text != string.Empty))
            {

                SqlConnection connection =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(
                        "Proc_AddNewProduct", connection);

                    cmd.CommandType = CommandType.StoredProcedure;

                    int iqty = Convert.ToInt32(qtyentrytextBox.Text);
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
                MessageBox.Show("All product information must be entered prior to adding.", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
   
}
