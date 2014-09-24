using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping
{
    public partial class Form4 : Form
    {
        public string bank;
        public double cost;
        

        public Form4()
        {
            InitializeComponent();
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome To " + bank;
            int a;
            Random ra = new Random();
            a = ra.Next(12345, 56789);
            label4.Text = a.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter UserName");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter PassWord");
            }
            else if (label4.Text != textBox3.Text)
            {
                MessageBox.Show("Verification Failed");
            }
            else if (textBox2.Text == "admin" && textBox1.Text == "admin"&&label4.Text==textBox3.Text)
            {
                Form5 f5 = new Form5();
               
                f5.banks = bank;
                f5.cost = cost;
                f5.Show();
                this.Hide();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
