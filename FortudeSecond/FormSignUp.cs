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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtComPassword.Text))
            {
                MessageBox.Show("Fill all the necessary fields", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string sqlquery = "insert into [dbo].[User] values (@UserName,@Password,@Name,@TelNo,@BillAddress,@ShipAddress,@UserType)";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
                string usertype = rbtnAdmin.Checked ? "A" : "C";
                sqlcomm.Parameters.AddWithValue("@UserName", txtUserName.Text);
                sqlcomm.Parameters.AddWithValue("@Password", txtPassword.Text);
                sqlcomm.Parameters.AddWithValue("@Name", txtName.Text);
                sqlcomm.Parameters.AddWithValue("@TelNo", txtTelNo.Text);
                sqlcomm.Parameters.AddWithValue("@BillAddress", txtBillAddress.Text);
                sqlcomm.Parameters.AddWithValue("@ShipAddress", txtShipAddress.Text);
                sqlcomm.Parameters.AddWithValue("@UserType", usertype);
                sqlcomm.ExecuteNonQuery();
                labelMsg.Text = "User " + txtUserName.Text + " Is Successfully Registered";

                sqlconn.Close();
            }

               
        }

        private void txtComPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Password Is Not Matching");
                txtComPassword.Focus();
                return;
            }
        }

        private void NavDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard f1 = new AdminDashboard();
            f1.Show();
            this.Hide();
        }

        private void txtTelNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelNo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
