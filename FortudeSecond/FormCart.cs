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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[User] where UserName ='" + FormLogin.currentUserName +"' and Password='"+FormLogin.currentUserPassword+"'";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
           // sqlcomm.Parameters.AddWithValue("@UserName", FormLogin.currentUserName);
            //sqlcomm.Parameters.AddWithValue("@Password", FormLogin.currentUserPassword);
            using(SqlDataReader dr = sqlcomm.ExecuteReader())
            {
                if(dr.Read())
                {
                    lblName.Text = dr["Name"].ToString();
                    lblTel.Text = dr["TelNo"].ToString();
                    lblShipto.Text = dr["ShipAddress"].ToString();
                    lblBillto.Text = dr["BillAddress"].ToString();
                }
            }

            //combobox
            comboBoxItems.Items.Clear();
            
            string query = "Select * from [dbo].[ItemDetails]";
            
            SqlCommand cmd = new SqlCommand(query, sqlconn);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
           
            sda.Fill(dt);

            comboBoxItems.DataSource = dt;
            comboBoxItems.DisplayMember = "Name";
            comboBoxItems.ValueMember = "Price";

            //foreach (DataRow dr in dt.Rows)
            //{
            //    comboBoxItems.Items.Add(dr["Name"].ToString());
            //    comboBoxItems.ValueMember.dr["Price"].ToString();
                
            //    //comboBoxItems.SelectedValue.ToString();// = (dr["Price"].ToString());
            //}
            sqlconn.Close();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin f1 = new FormLogin();
            f1.Show();
            this.Hide();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var price = int.Parse(comboBoxItems.SelectedValue.ToString());

                var x = txtQty.Text.ToString();
                if (!string.IsNullOrWhiteSpace(x))
                {

                    var qty = int.Parse(txtQty.Text.ToString());

                    var total = price * qty;

                    txtPrice.Text = total.ToString();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
