﻿using System;
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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            
            setupListView();

        }

        private void setupListView()
        {

            String connectionString = "Data Source=localhost;Initial Catalog=POS;Persist Security Info=True;User ID=dbapp;Password=mar";

            SqlConnection connection =
                       new SqlConnection(connectionString);

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
                    this.listView1.Items.Add(lvi);
                }

                rdr.Close();
            }

            catch (Exception ex)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmpForm ae = new AddEmpForm();
            ae.Show();
        }
    }
}
