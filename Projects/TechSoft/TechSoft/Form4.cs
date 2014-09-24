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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "")
            {
                try
                {
                    int c = 0;
                    OdbcConnection connection = new OdbcConnection("DSN=techsoft");
                    connection.Open();

                    string url = "select * from table1 where post='" + textBox1.Text + "'";

                    OdbcCommand oc = new OdbcCommand(url, connection);
                    OdbcDataReader a = oc.ExecuteReader();

                    while (a.Read())
                    {
                        richTextBox1.Text = a.GetString(1).ToString();
                        
                        c++;
                    }
                   
                    connection.Close();
                    if (c == 0)
                    {
                        MessageBox.Show("Not Found In Database!!! Add Fisrt");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Some Bugs !!!Comment In Tech Soft Page.:\nBug.:\n" + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Enter the Word To Search");
            }
                   
                  
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
