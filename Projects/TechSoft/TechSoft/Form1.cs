using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace TechSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (richTextBox1.Text != "")
                {
                    try
                    {
                        OdbcConnection tc = new OdbcConnection("DSN=techsoft");
                        tc.Open();
                        string url = "INSERT INTO Table1(post,detail) VALUES('" + textBox1.Text + "','" + richTextBox1.Text + "')";
                        OdbcCommand ocd = new OdbcCommand(url, tc);
                        ocd.ExecuteNonQuery();
                        tc.Close();
                        MessageBox.Show("Words Added Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Some Bugs!!!Comment In Tech Soft Page.:\nBug.:\n" + ex.Message);

                    }
                   

                }
            }
            if (richTextBox1.Text== "")
            {
                MessageBox.Show("Enter Word");
            }
            else if (richTextBox1.Text == "")
            {
                MessageBox.Show("Enter Meaning");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Close();
        }
    }
}
