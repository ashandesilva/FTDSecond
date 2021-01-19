using FortudeSecond.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortudeSecond
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        //UserClass  UserName = "";
        public static string currentUserName = "";
        public static string currentUserPassword = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            string sqlquery = "Select * from [dbo].[User] where UserName = @UserName and Password=@Password";
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn);
            sqlcomm.Parameters.AddWithValue("@UserName", txtUsername.Text);
            sqlcomm.Parameters.AddWithValue("@Password", txtPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlcomm.ExecuteNonQuery();
            
            if(dt.Rows.Count>0)
            {
                using (SqlDataReader dr = sqlcomm.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string type = dr["UserType"].ToString();
                        if (type == "A         ")
                        {
                            currentUserName = txtUsername.Text;
                            currentUserPassword = txtPassword.Text;
                            AdminDashboard f1 = new AdminDashboard();
                                f1.Show();
                                this.Hide();
                        }
                        else
                        {
                            currentUserName = txtUsername.Text;
                            currentUserPassword = txtPassword.Text;
                            FormCart f = new FormCart();
                            f.Show();
                            this.Hide();
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }

            txtUsername.Text = "";
            txtPassword.Text = "";

        }
    }
}
