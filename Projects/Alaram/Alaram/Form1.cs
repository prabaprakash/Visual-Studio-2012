using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alaram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            timer1.Interval = 60 * 1000 * int.Parse(textBox1.Text);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Wake Up");
            timer1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
     
            Font f = new Font("Arial", 14);
            textBox3.Font = f;
            textBox3.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }


    }
}
