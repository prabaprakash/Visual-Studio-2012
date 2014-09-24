using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progress_Bar
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

            mat();
        }
        public void mat()
        {
            Double i, a = Convert.ToDouble(textBox1.Text);

            Double g = 1;
            for (i = 1; i <= a; i++)
            {
                g *= i;
                progressBar1.Maximum = Convert.ToInt32(g);
                progressBar1.Value = Convert.ToInt32(g);
            }
            MessageBox.Show(g.ToString());
        }
    }
}
