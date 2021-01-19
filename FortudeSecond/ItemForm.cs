using FortudeFirst.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortudeFirst
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        ItemClass c = new ItemClass();

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxPrice.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Name = textBoxName.Text;
            var x = textBoxPrice.Text;

            if (string.IsNullOrWhiteSpace( Name) || string.IsNullOrWhiteSpace(x))
            {
                MessageBox.Show("Fill all the fields", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                c.Price = int.Parse(x);


                bool success = c.Insert(c);
                if (success == true)
                {
                    MessageBox.Show("Successfull");
                }
                else
                {
                    MessageBox.Show("Failed");
                }

                DataTable dt = c.Select();
                dataGridView1.DataSource = dt;
            }   

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm f3 = new CartForm();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm f1 = new CustomerForm();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            // Key Enum 
            // 8 - The BACKSPACE key.
            // 46 - DEL Key

            if (!Char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
