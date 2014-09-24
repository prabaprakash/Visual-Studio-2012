using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using System.Data.SQLite;

namespace Unicode_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

             char s='"';
             
                using (StreamWriter writer = new StreamWriter("h.txt", false, Encoding.UTF8))
                {
                    MessageBox.Show("ok");
                    //SQLiteConnection cnn = new SQLiteConnection("Data Source=Data/encrypted.db3;Version=3;New=True;");
                    //cnn.Open();
                    //String cm = "select * from embed";

                    //SQLiteCommand sq = new SQLiteCommand(cm, cnn);
                    //SQLiteDataReader r = sq.ExecuteReader();
                    //while (r.Read())
                    //{
                    //    writer.WriteLine("a[" + r.GetInt32(0) + "]=" + s + r.GetString(1) + s + ";");
                    //    writer.WriteLine("b[" + r.GetInt32(0) + "]=" + s + r.GetString(2) + s + ";");


                    //}
                    OdbcConnection oc = new OdbcConnection("DSN=prakash");
                    oc.Open();
                    String cm = "Select * from Table1;";
                    OdbcCommand cd = new OdbcCommand(cm, oc);
                    OdbcDataReader r = cd.ExecuteReader();
                    Double i = 1;
                    while (r.Read())
                    {
                        writer.WriteLine("a[" +i+ "]=" + s + r.GetString(0) + s + ";");
                        writer.WriteLine("b[" +i+ "]=" + s + r.GetString(1) + s + ";");
                        i++;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
