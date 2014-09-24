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
    public partial class Form1 : Form
    {
        public Double c, d, cost;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            //MessageBox.Show(radioButton1.Checked.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String a=radioButton1.Checked.ToString();
            String b=radioButton2.Checked.ToString();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Item No");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Enter Item Name");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Enter Item Price");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Enter No Of Qunatity");
            }
            
            else if (a == "True")
            {
                cost = double.Parse(textBox3.Text) * double.Parse(textBox4.Text);
                textBox5.Text = cost.ToString();
                //MessageBox.Show(cost.ToString() + ".Rs You Have To Pay To Buy The Item");
                Form2 f2 = new Form2();
                f2.x = cost;
                f2.Show();
                this.Hide();

            }
            else if (b == "True")
            {
                cost = double.Parse(textBox3.Text) * double.Parse(textBox4.Text);
                textBox5.Text = cost.ToString();
                MessageBox.Show(cost.ToString() + ".Rs You Have To Pay To Buy The Item");
                Form2 f2 = new Form2();
                Form3 f3 = new Form3();
                f3.y = cost;
                f3.Show();
                this.Hide();
            }
        }

    }
}
