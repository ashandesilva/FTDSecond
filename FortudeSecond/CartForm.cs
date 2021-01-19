using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortudeFirst
{
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();
        }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["FortudeFirst.Properties.Settings.FortudeFirstConnectionString"].ConnectionString;

        //private void FillCombo()
        //{
        //    SqlConnection conn = new SqlConnection(myconnstrng);
        //    string sql = "SELECT * FROM dbo.CustomerDetails ;";
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    SqlDataReader myReader;
        //    try
        //    {

        //        conn.Open();
        //        myReader = cmd.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            string cName = myReader.GetString("name");
        //            comboBox1.Items.Add(cName);
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm f2 = new ItemForm();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm f1 = new CustomerForm();
            f1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                using (WinFormsFortudeFirstEntities1 db = new WinFormsFortudeFirstEntities1())
                {
                    comboBoxCustomer.DataSource = db.CustomerDetails.ToList();
                    comboBoxCustomer.ValueMember = "CustomerId";
                    comboBoxCustomer.DisplayMember = "name";

                    comboBoxItem.DataSource = db.ItemDetails.ToList();
                    comboBoxItem.ValueMember = "Price";
                    comboBoxItem.DisplayMember = "name";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{
        //    var price = comboBox2.ValueMember.ToString();
        //    var qty = int.Parse(numericUpDown1.Value.ToString());
        //    var iprice = int.Parse(price);
        //    var Total = iprice * qty;
        //    textBox2.Text = Total.ToString();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxQty.Text.Equals(""))
                {
                    MessageBox.Show("Add Qty", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var price = int.Parse(comboBoxItem.SelectedValue.ToString());
                    var qty = int.Parse(textBoxQty.Text.ToString());

                    var total = price * qty;

                    textBoxTotal.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            
        }

        private void NavCustomer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CustomerForm f1 = new CustomerForm();
            f1.Show();
        }

        private void NavItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm f2 = new ItemForm();
            f2.Show();
        }

        



        private void textBoxQty_KeyUp(object sender, KeyEventArgs e)
        {

            //try
            //{

            //    var price = int.Parse(comboBoxItem.SelectedValue.ToString());

            //    var x = textBoxQty.Text.ToString();
            //    if (!string.IsNullOrWhiteSpace(x))
            //    {

            //        var qty = int.Parse(textBoxQty.Text.ToString());

            //        var total = price * qty;

            //        textBoxTotal.Text = total.ToString();
            //    }
                


            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void textBoxQty_TextChanged(object sender, EventArgs e)
        {
            try
            {

                var price = int.Parse(comboBoxItem.SelectedValue.ToString());

                var x = textBoxQty.Text.ToString();
                if (!string.IsNullOrWhiteSpace(x))
                {

                    var qty = int.Parse(textBoxQty.Text.ToString());

                    var total = price * qty;

                    textBoxTotal.Text = total.ToString();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
