using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace Printer_Opertion_In_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.printPreviewDialog1 = new PrintPreviewDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int xPos = 12;
            int yPos = 12;
            Graphics g = e.Graphics;
            using (Font fon = new Font("Italics", 14))
            {
                g.DrawString("Text", fon, Brushes.Black, new PointF(xPos, yPos));
            }
          


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
  PrintController standard = new StandardPrintController();
  // Can change the title from "Printing" to something else
  PrintController status =
    new PrintControllerWithStatusDialog(standard, "Printing");
  printDocument1.PrintController = status;
  printDocument1.Print();
}

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }



        
    }
}
