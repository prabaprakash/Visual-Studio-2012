using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Odbc;

namespace Database_Converter
{
    public partial class add : Form
    {
       public int i;
        public add()
        {
            InitializeComponent();
        }

        private void add_Load(object sender, EventArgs e)
        {
            
            i = Database_Converter.Properties.Settings.Default.k_no;
            i = i + 1;
            textBox1.Text = i.ToString();
            Database_Converter.Properties.Settings.Default.k_no = int.Parse(textBox1.Text);
            //Database_Converter.Properties.Settings.Default.k_no = 0;
            Database_Converter.Properties.Settings.Default.Save();
            richTextBox1.Text = Database_Converter.Properties.Settings.Default.sec_no.ToString();
            richTextBox4.Text=Database_Converter.Properties.Settings.Default.scetion;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text== "")
            {
            }
            else
            {
                Database_Converter.Properties.Settings.Default.k_no = int.Parse(textBox1.Text);
                //Database_Converter.Properties.Settings.Default.k_no = 0;
                Database_Converter.Properties.Settings.Default.Save();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
            }
            else
            {
                Database_Converter.Properties.Settings.Default.sec_no = int.Parse(richTextBox1.Text);
                //Database_Converter.Properties.Settings.Default.k_no = 0;
                Database_Converter.Properties.Settings.Default.Save();
            }
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox4.Text == "")
            {
            }
            else
            {
                Database_Converter.Properties.Settings.Default.scetion = richTextBox4.Text;
                //Database_Converter.Properties.Settings.Default.k_no = 0;
                Database_Converter.Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OdbcConnection oc = new OdbcConnection("DSN=prakash");
                oc.Open();
                String cmm = "Select * from Sheet1;";
                OdbcCommand cd = new OdbcCommand(cmm, oc);
                OdbcDataReader r = cd.ExecuteReader();

                SQLiteConnection conn = new SQLiteConnection("Data Source=EKural.db3;Version=3;New=True; ");
                conn.Open();
                int p = int.Parse(textBox1.Text);
                int q = int.Parse(richTextBox1.Text);

                //var trans = conn.BeginTransaction();
                
               //string c = "insert into kural values("+p+", "+q+",'"+richTextBox4.Text.ToString().TrimEnd()+"', '"+richTextBox2.Text.ToString().TrimEnd()+"', '"+richTextBox3.Text.ToString().TrimEnd()+"')";
                //int j = 1;
                String d="";
                int g = 0;
                while (r.Read())
                {
                    if (r.GetInt16(0) == 861 || r.GetInt16(0) == 862)
                    {
                    }
                    else
                    {
                        string c = String.Format("insert into kural values({0}, {1},'{2}', '{3}', '{4}')", r.GetInt16(0), g, r.GetString(4), r.GetString(5), d);
                        SQLiteCommand cm = new SQLiteCommand(c, conn);
                        cm.ExecuteNonQuery();
                    }
                     //j++;
                }
                //string c = "insert into kural values(1,2,'eruue','rer','rer')";
               
               
                MessageBox.Show("inserted");
                //i = i + 1;
                //textBox1.Text = i.ToString();
                
               // trans.Commit();
               
                conn.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            richTextBox5.Text="Üî¤è£óñ¢ 1. ºîø¢ðèõù¢ õ¿î¢¶Üçî£õ¶, Ýê¤ó¤òù¢ î£ù¢ Þòø¢Áñ¢ Ëô¢ Þ¬ìÎø¤ù¢ø¤ Þù¤¶ º®îø¢ªð£¼ì¢´ñ¢, îù¢ Ëô¤ø¢° «õí¢®ò ªî÷¢÷¤ò Üø¤¬õ Üø¤õ¤ø¢°ð¢ ð¤øð¢ð¤ìñ£è¤ò Þ¬øõù¤ìî¢î¤ù¤ù¢Á ªðøø¢ªð£¼ì¢´ñ¢, Þ¬øõù¼÷¢ àôè ïìð¢ð¤ø¢° Þù¢ø¤ò¬ñò£î ºîø¢èóíñ£îô¤ù¢ Ü¬îî¢ «î´îø¢° âô¢ô£ ñ£ï¢î¼ñ¢ âõ¢õ¤¬ù¬ò»ñ¢ Þ¬øõ¬ùî¢ ªî£¿«î ªî£ìé¢èô¢ «õí¢´ñ¢ âù¢Âñ¢ ªïø¤º¬ø¬ò àôè¤ø¢° àíó¢î¢îø¢ ªð£¼ì¢´ñ¢, Þ¬øõ¬ù õ¿î¢¶îô¢. õ¿î¢¶îô¢ - «ð£ø¢Áîô¢. ¶î¤î¢îô¢ âù¢ð¶ õìªê£ô¢. ê¤Áªîò¢õ õíè¢èñ¢, ªð¼ï¢«îõ õíè¢èñ¢, èì¾÷¢ õíè¢èñ¢ âù º¬ø«ò åù¢ø¤ªù£ù¢Áòó¢ï¢î Íõ¬è õíè¢èé¢èÀ÷¢, Þ¶ èì¾÷¢ õíè¢èñ¢. èì¾÷¢ âù¢Âñ¢ ªê£ô¢ Þñ¢ ºîôî¤è£óð¢ ðî¢¶è¢ °ø÷¢èÀ÷¢ åù¢ø¤«ôÂñ¢ õ£ó£¬ñò£Âñ¢ , ºîø¢°ø÷¤ô¢ Ýî¤ðèõù¢ âù¢Âñ¢ ªðò«ó °ø¤è¢èð¢ ªðø¢ø¤¼î¢îô£Âñ¢, èì¾÷¢ õ£ö¢î¢¶ Þé¢° ºîø¢ðèõù¢ õ¿î¢¶ âùð¢ ªðø¢ø¶. õ£ö¢î¢¶ âù¢Âñ¢ ªê£ô¢ ñè¢è¬÷ õ£ö¢õ¤î¢î½ñ¢ Þ¬øõ¬ùð¢ «ð£ø¢Áî½ñ¢ Ýè¤ò Þ¼ªð£¼÷¢ îï¢¶ ñòé¢èø¢è¤ìù£è ï¤ø¢øô£ô¢, õ¿î¢¶ âù¢Âñ¢ ªê£ô¢¬ô Üîù¤ù¢Á î¤ó¤î¢îùó¢ ºù¢¬ù òø¤ëó¢. Üî¤èó¤î¢î¶ Üî¤è£óñ¢. Þ¶ Þôè¢èí Ëô¢è÷¤ø¢ ªð¼ñ¢ ð°î¤¬òè¢ °ø¤è¢°«ñÂñ¢, Þé¢° àì¢ê¤Áð°î¤¬òè¢ °ø¤è¢°ñ£Á Ý÷ð¢ðì¢ì¶. ";
        }
    }
}
