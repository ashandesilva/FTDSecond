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
    public partial class FormUserMgt : Form
    {
        public FormUserMgt()
        {
            InitializeComponent();
        }
        string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

        private void NavDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard f1 = new AdminDashboard();
            f1.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(mainconn);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from [FortudeSecond].[dbo].[User] where UserName ='"+txtUserName+"'" , con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Succesfully");
            dataGridViewUsers.DataSource = GetUsers();

        }

        private void FormUserMgt_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.DataSource = GetUsers();
        }

        private DataTable GetUsers()
        {
            DataTable users = new DataTable();

            //string mainconn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(mainconn))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM [FortudeSecond].[dbo].[User]", con))
                {
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    users.Load(reader);


                }
            }
            return users;
        }
    }
}
