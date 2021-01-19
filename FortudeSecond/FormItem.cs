using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FortudeSecond
{
    public partial class FormItem : Form
    {
        public FormItem()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void NavDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard f1 = new AdminDashboard();
            f1.Show();
            this.Hide();
        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            dataGridItems.DataSource = GetItems();
        }

        private DataTable GetItems()
        {
            DataTable items = new DataTable();

            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(mainconn))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ItemDetails", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    items.Load(reader);


                }
            }
            return items;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Fill all the fields", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[ItemDetails] values (@Name,@Price)";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);


                sqlcomm.Parameters.AddWithValue("@Name", txtName.Text);
                sqlcomm.Parameters.AddWithValue("@Price", txtPrice.Text);

                sqlcomm.ExecuteNonQuery();
                // labelMsg.Text = "User " + txtName.Text + " Is Successfully Registered";

                sqlconn.Close();
                MessageBox.Show("Successfull!");
                dataGridItems.DataSource = GetItems();




            }
            
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            // Key Enum 
            // 8 - The BACKSPACE key.
            // 46 - DEL Key

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void dataGridItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
