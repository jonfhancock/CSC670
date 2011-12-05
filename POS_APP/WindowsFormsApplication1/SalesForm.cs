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

    public partial class SalesForm : Form
    {

        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

            SqlConnection connection =
                       new SqlConnection(Program.CONNECTION_STRING);

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

            catch (Exception ex)
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


        private void empIDTextBox_TextLeave(object sender, EventArgs e)
        {

            string eID = empIDTextBox.Text;

            SqlConnection connection =
                       new SqlConnection(Program.CONNECTION_STRING);
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
            catch (Exception ex)
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

                
        private void customerIDTextBox_TextLeave(object sender, EventArgs e)
        {

            string custID = customerIDTextBox.Text;

            SqlConnection connection =
                       new SqlConnection(Program.CONNECTION_STRING);

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
            catch (Exception ex)
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

        private void itemEntryTextBox_TextLeave(object sender, EventArgs e)
        {

            string itemID = itemEntryTextBox.Text;

            SqlConnection connection =
                       new SqlConnection(Program.CONNECTION_STRING);
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
            catch (Exception ex)
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



        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection =
                           new SqlConnection(Program.CONNECTION_STRING);
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
           
                foreach (ListViewItem lvi in this.itemsListView.Items)
                {

                    SqlConnection conItems =
                                   new SqlConnection(Program.CONNECTION_STRING);
                    SqlConnection conInv =
                                    new SqlConnection(Program.CONNECTION_STRING);
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
                               new SqlConnection(Program.CONNECTION_STRING);

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

                salecmd.ExecuteNonQuery();
                conSale.Close();
                
                this.Close();
            }
            catch (Exception ex)
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

        private string itemTotal(string price, string qty)
        {
            decimal total = new decimal();
            decimal dPrice = Convert.ToDecimal(price);
            int iqty = (int)Convert.ToInt32(qty);

            total = dPrice * iqty;
            return total.ToString();
        }
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

        private void cleanUpItemsToAdd()
        {
            int locationOfTotalInListView = 4;
            int dp = 2; //decimal Precision
            itemEntryTextBox.Text = string.Empty;
            iDescTextBox.Text = string.Empty;
            priceTextBox.Text = string.Empty;
            qtyentrytextBox.Text = "1";

            decimal st = 0;
                
            foreach ( ListViewItem lvi in this.itemsListView.Items)
            {

                st = st + Convert.ToDecimal(lvi.SubItems[locationOfTotalInListView].Text);
            }
            decimal taxRate = .081M;
            decimal tax = Math.Round (taxRate * st, dp);
            decimal total = Math.Round(st + tax, dp);
            subTotalTextBox.Text = st.ToString();
            taxTextBox.Text = tax.ToString();
            TotalTextBox.Text = total.ToString();

        }
      }    
    }
            

