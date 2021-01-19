using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FortudeSecond
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void NavRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignUp f1 = new FormSignUp();
            f1.Show();
        }

        private void NavItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormItem f1 = new FormItem();
            f1.Show();
        }

        private void NavOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrder f1 = new FormOrder();
            f1.Show();
        }

        private void NavUserMgt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUserMgt f1 = new FormUserMgt();
            f1.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            lblAdminName.Text = FormLogin.currentUserName;
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin f1 = new FormLogin();
            f1.Show();
            this.Hide();
        }
    }
}
