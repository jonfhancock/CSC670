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
    /// The Form that supports the sale of the products
    /// </summary>
    public partial class SalesForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SalesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Setup the Sales Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesForm_Load(object sender, EventArgs e)
        {
                      
            SqlConnection connection =
                       new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

            //SqlConnection connection =
            //           new SqlConnection(ConfigurationManager.AppSettings["connectionStrings"]
            ////Program.CONNECTION_STRING);
            //);


            /*
            SqlConnection connection =
                      new SqlConnection(Program.CONNECTION_STRING);            
             */


            SqlDataReader rdr  = null;
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "Proc_PossiblePayments", connection);

                cmd.CommandType = CommandType.StoredProcedure;


                // execute the command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    this.payComboBox.Items.Add(rdr[0]);
                }

                rdr.Close();
            }

            catch (Exception)
            {
                connection.Close();
                customerIDTextBox.Text = String.Empty;
                customerIDTextBox.Focus();

            }
            finally
            {
                connection.Close();
            }

        }

        /// <summary>
        /// Event handler to look up the Employee info for the employee id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void empIDTextBox_TextLeave(object sender, EventArgs e)
        {

            string eID = empIDTextBox.Text;

            SqlConnection connection =
                       new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
            SqlDataReader rdr = null;
            try
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand(
                    "Proc_EmployeeLookUpForASale", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@@empid", eID));

                // execute the command
                rdr = cmd.ExecuteReader();
                rdr.Read();

                this.empNameAnsTextBox.Text = rdr["fname"].ToString();
                this.emplnameTextBox.Text = rdr["lname"].ToString();
                rdr.Close();

            }
            catch (Exception)
            {
                connection.Close();
                if (empIDTextBox.Text != string.Empty)
                {
                    connection.Close();
                    empIDTextBox.Text = String.Empty;
                    MessageBox.Show("Please verify the employee number. \nThe number you entered was not found.",
                        "Employee not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    empIDTextBox.Focus();
                }

            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Event handler to look up the customer info for the customer id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>                
        private void customerIDTextBox_TextLeave(object sender, EventArgs e)
        {

            string custID = customerIDTextBox.Text;

            SqlConnection connection =
                       new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

            SqlDataReader rdr  = null;
            
            try
            {

               connection.Open();
                
                SqlCommand cmd = new SqlCommand(
                    "Proc_CustomerLookUp", connection);
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@@custid", custID));

                // execute the command
                rdr = cmd.ExecuteReader();
                rdr.Read();

                this.custFnameTextBox.Text = rdr["fname"].ToString();
                this.custLnameTextBox.Text = rdr["lname"].ToString();
                this.custAddressTextBox.Text = rdr["address"].ToString();
                rdr.Close();
                
            }
            catch (Exception)
            {
                rdr.Close();
                connection.Close();
                if (customerIDTextBox.Text != string.Empty)
                {
                    connection.Close();
                    customerIDTextBox.Text = String.Empty;
                    MessageBox.Show("Please verify the customer number. \nThe number you entered was not found.",
                        "Customer not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerIDTextBox.Focus();
                }

            }
            finally
            {
                rdr.Close();
                connection.Close();
            }
        }

        /// <summary>
        /// Event handler to look up the items info trying to be purchased
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void itemEntryTextBox_TextLeave(object sender, EventArgs e)
        {

            string itemID = itemEntryTextBox.Text;

            SqlConnection connection =
                       new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
            SqlDataReader rdr  = null;
            try
            {

                // Open the connection. 
                connection.Open();

                
                SqlCommand cmd = new SqlCommand(
                    "Proc_ProductForItemList", connection);
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(
                    new SqlParameter("@@pid", itemID));

                // execute the command
                rdr = cmd.ExecuteReader();
                rdr.Read();

                this.iDescTextBox.Text = rdr["pdescript"].ToString();
                this.priceTextBox.Text = rdr["price"].ToString();

                connection.Close();
            }
            catch (Exception)
            {
                if (itemEntryTextBox.Text != string.Empty)
                {
                    connection.Close();
                    itemEntryTextBox.Text = String.Empty;
                    MessageBox.Show("Please verify the product number. \nThe number you entered was not found.",
                        "Item not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    itemEntryTextBox.Focus();
                }

            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// The user canceled the sale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// The sale needs to be commited gather the data and save it to the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
            SqlDataReader rdr  = null;
            try
            {

                // Open the connection. 
                connection.Open();
                
                SqlCommand cmd = new SqlCommand(
                    "Proc_NextSaleId", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                
                // execute the command
                rdr = cmd.ExecuteReader();
                rdr.Read();

                string maxSid = rdr["lastId"].ToString();
                int saleID = int.Parse(maxSid) + 1;

                connection.Close();
           
                //Gather all the items that were being sold
                foreach (ListViewItem lvi in this.itemsListView.Items)
                {

                    SqlConnection conItems =
                                   new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                    SqlConnection conInv =
                                    new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);
                    conItems.Open();

                    SqlCommand itemcmd = new SqlCommand(
                        "Proc_ItemSold", conItems);

                    itemcmd.CommandType = CommandType.StoredProcedure;

                    itemcmd.Parameters.Add(
                      new SqlParameter("@@sid", saleID));
                    itemcmd.Parameters.Add(
                      new SqlParameter("@@pid", lvi.SubItems[0].Text));
                    itemcmd.Parameters.Add(
                      new SqlParameter("@@qSold", lvi.SubItems[3].Text));
                    itemcmd.Parameters.Add(
                      new SqlParameter("@@sPrice", lvi.SubItems[2].Text));

                    itemcmd.ExecuteNonQuery();
                    conItems.Close();
                    
                }

                SqlConnection conSale =
                               new SqlConnection(ConfigurationManager.ConnectionStrings["Connect"].ConnectionString);

                int paymentCode = payComboBox.SelectedIndex+1;

                conSale.Open();

                SqlCommand salecmd = new SqlCommand(
                    "Proc_InsertSale", conSale);

                salecmd.CommandType = CommandType.StoredProcedure;

                salecmd.Parameters.Add(
                  new SqlParameter("@@sid", saleID));
                salecmd.Parameters.Add(
                  new SqlParameter("@@d", System.DateTime.Today.ToShortDateString()));                
                salecmd.Parameters.Add(
                  new SqlParameter("@@ptype", paymentCode));
                salecmd.Parameters.Add(
                  new SqlParameter("@@empId", this.empIDTextBox.Text));
                salecmd.Parameters.Add(
                  new SqlParameter("@@cId", this.customerIDTextBox.Text));

                //Commite the Sale to the DB
                salecmd.ExecuteNonQuery();
                conSale.Close();

                MessageBox.Show("A receipt would be printed for the customer at this time. \n Currently this is a future function.", "Print Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("This Sale had an error and was not saved. \nPlease reenter your sale.",
                    "Sale not Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
             finally
             {
                 connection.Close();
             }

        }

        /// <summary>
        /// Helper method to claculate totals by how many of the items are being purchased
        /// </summary>
        /// <param name="price"></param>
        /// <param name="qty"></param>
        /// <returns></returns>
        private string itemTotal(string price, string qty)
        {
            decimal total = new decimal();
            decimal dPrice = Convert.ToDecimal(price);
            int iqty = Convert.ToInt32(qty);

            total = dPrice * iqty;
            return total.ToString();
        }

        /// <summary>
        /// Adds the item to the list of items to be purchased
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            string[] sItems = (new string[]
            {
                itemEntryTextBox.Text,
                iDescTextBox.Text,
                priceTextBox.Text,
                qtyentrytextBox.Text,
                itemTotal(priceTextBox.Text,qtyentrytextBox.Text)
            }  );

            ListViewItem lvi = new ListViewItem(sItems);
            this.itemsListView.Items.Add(lvi);

            cleanUpItemsToAdd();                      
            itemEntryTextBox.Focus();
            payComboBox.Enabled = true;

        }

        /// <summary>
        /// Cleans up the item entry line after the add button has been sleected
        /// </summary>
        private void cleanUpItemsToAdd()
        {
            int locationOfTotalInListView = 4;
            int dp = 2; //decimal Precision
            itemEntryTextBox.Text = string.Empty;
            iDescTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;

            //Assume majority of time that only one of the products is being bought
            qtyentrytextBox.Text = "1";

            //The monetary total for the sale.  Alreadys has quantity * price determeined
            decimal saleTotal = 0;
                
            //Get the quantity of the 
            foreach ( ListViewItem lvi in this.itemsListView.Items)
            {

                saleTotal = saleTotal + Convert.ToDecimal(lvi.SubItems[locationOfTotalInListView].Text);
            }

            //Deal with Tax
            decimal tr = Convert.ToDecimal( ConfigurationManager.AppSettings["TaxRate"]);
            decimal tax = Math.Round(tr * saleTotal, dp);
            
            //Determine Totals
            decimal total = Math.Round(saleTotal + tax, dp);
            subTotalTextBox.Text = saleTotal.ToString();
            taxTextBox.Text = tax.ToString();
            TotalTextBox.Text = total.ToString();

        }
      }    
    }
            

