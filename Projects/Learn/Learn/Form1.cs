using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);

            //Foreach in C#
            foreach (int b in a)
            {
                MessageBox.Show(b.ToString());
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Do While in C#WF
            int i = 0;
            do
            {
                textBox1.Text += i.ToString();
                i++;
            } while (i < 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = 6;
                if (a > 8)
                {
                    MessageBox.Show(a.ToString());
                }
                else
                {
                    throw new Exception("a is less than 8 error");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MessageBox.Show("Your Code IS Done");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            message("Praba");
        }
        public void message(string message)
        {
            MessageBox.Show(message);
        }
        public int mess(int a)
       {
        return(a);
       }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mess(5).ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 2) continue;
                textBox2.Text += i.ToString();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 2) break ;
                textBox3.Text += i.ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(textBox4.Text);
            lvi.SubItems.Add(textBox5.Text);
            lvi.SubItems.Add(textBox6.Text);
            listView1.Items.Add(lvi);
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
