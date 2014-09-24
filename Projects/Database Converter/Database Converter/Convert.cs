using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlServerCe;
using System.IO;
using System.Drawing.Imaging;
using System.Reflection;
using System.Data.Odbc;
namespace Database_Converter
{
    public partial class Convert : Form
    {
        public Convert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            //try
            //{


            //    //SQLiteConnection cn = new SQLiteConnection("Data Source=Data/Thirukkural.db3;version=3;New=True");
            //    //cn.Open();

            //    //string d = "select * from Table1";
            //    //MessageBox.Show("g");

            //    //SQLiteCommand scmd = new SQLiteCommand(d, cn);
            //    //SQLiteDataReader a = scmd.ExecuteReader();
            //OdbcConnection oc = new OdbcConnection("DSN=prakash");
            //oc.Open();
            //String cm = "Select * from Sheet1;";
            //OdbcCommand cd = new OdbcCommand(cm, oc);
            //OdbcDataReader r = cd.ExecuteReader();
                

            //    Double i=1;
            //    MessageBox.Show("a");

            //    SQLiteConnection conn = new SQLiteConnection("Data Source=Data/kural;Version=3;New=True; ");
               
            //    richTextBox1.Text = "";
            //    conn.Open();
                

            //    // Encrypts the database. The connection remains valid and usable afterwards.

            //   // conn.ChangePassword("then");
                



            //    //   
            //    using (var trans = conn.BeginTransaction())
            //    {
            //        double p,l;
            //        string m,n;

            //        while (r.Read())
            //      {

            //          p = r.GetDouble(1);
            //            l=r.GetDouble(3);
            //            m = r.GetString(4);
            //            n = r.GetString(5);
            //          richTextBox1.Text = p+ "\n" +l+ "\n" + m + "\n" +n;
            //      //  string s = "insert into kural (no,tno,section,kural) values("+r.GetDouble(1)+","+r.GetDouble(3)+",'"+r.GetString(4)+"','"+r.GetString(5)+"');";
            //        //SQLiteCommand cmd = new SQLiteCommand(s, conn);
                 
            //        //cmd.ExecuteNonQuery();
                    
            //        i++;

            //       }
            //        trans.Commit();
            //    }
          
                
            //    conn.Close();


            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            try
            {
                SQLiteConnection conn = new SQLiteConnection("Data Source=Data/Thirukkural.db3;Version=3;New=True; ");
                conn.Open();
                int a,b;
                a = int.Parse(textBox1.Text.ToString());
                b = int.Parse(textBox2.Text.ToString());

                string c = string.Format("insert into kural values({0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",a,b,richTextBox7.Text.ToString(),richTextBox1.Text.ToString(),richTextBox2.Text.ToString(),richTextBox3.Text.ToString(),richTextBox4.Text.ToString(),richTextBox5.Text.ToString(),richTextBox6.Text.ToString());
                var trans = conn.BeginTransaction();
                SQLiteCommand cm = new SQLiteCommand(c, conn);
                trans.Commit();
                conn.Close();
            }
            catch( SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=indexed.db"))
                {
                    // Be sure you already created the Person Table!

                    conn.Open();

                    var stopwatch = new Timer();
                    stopwatch.Start();

                    using (var cmd = new SQLiteCommand(conn))
                    {
                        using (var con = new SQLiteConnection(@"Data Source=encrypted.db3"))
                        {
                            con.Open();
                            String a = "select * from embed";
                            SQLiteCommand cm = new SQLiteCommand(a, con);
                            SQLiteDataReader eat = cm.ExecuteReader();
                            using (var transaction = conn.BeginTransaction())
                            {
                                // 100,000 inserts


                               // MessageBox.Show("fg");
                                while (eat.Read())
                                {
                                    cmd.CommandText = "INSERT INTO good (word) VALUES ('" + eat.GetString(1) + "');";
                                    cmd.ExecuteNonQuery();

                                }

                                transaction.Commit();
                            }
                        }

                    MessageBox.Show(timer1.Interval.ToString());

                        conn.Close();
                    }
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
              
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //OpenFileDialog a = new OpenFileDialog();
            //a.ShowDialog();
            //string v = a.ToString();
            //textBox1.Text = v;
          

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
           
            try
            {
                using(SqlCeConnection cn=new SqlCeConnection(@"Data Source=data.sdf"))
                {
                    byte[] data;
                    data = System.IO.File.ReadAllBytes(@"C:\Users\PrabaKarthi\Documents\Visual Studio 2012\Projects\Database Converter\Database Converter\photo.jpg");
                   
                    SqlCeCommand com = new SqlCeCommand("INSERT INTO image (pic)values(@DATA)", cn);
                    com.Parameters.AddWithValue("@DATA", data);
                    cn.Open();
                    
                    com.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("ff");
                }
            }
            catch(SqlCeException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                String mean="";
                int id = 0;
                SQLiteConnection co1 = new SQLiteConnection("Data Source=data1.db3");
                co1.Open();
                co1.BeginTransaction();
                string q1 = "select distinct(word) from  embed";
                SQLiteCommand cm1 = new SQLiteCommand(q1, co1);
                SQLiteDataReader r1 = cm1.ExecuteReader();
                while (r1.Read())
                {
                    id = id + 1;

                    // MessageBox.Show(r1.GetString(0));
                    SQLiteConnection co2 = new SQLiteConnection("Data Source=data2.db3");
                    co2.Open();
                   
                    //MessageBox.Show(r1.GetString(0));
                    string q2 = string.Format("select meaning from embed where word='{0}'", r1.GetString(0));
                    SQLiteCommand cm2 = new SQLiteCommand(q2, co2);
                    SQLiteDataReader r2 = cm2.ExecuteReader();
                    while (r2.Read())
                    {
                        //word += r2.GetString(1);
                       

                            mean+= r2.GetString(0)+"\n";
                     
                    }
                  // MessageBox.Show(mean.ToString());
                    co2.Close();
                    SQLiteConnection co3 = new SQLiteConnection("Data Source=good");
                    co3.Open();
                    string q3 = "insert into great(int,word,meaning)values(@id,@word,@meaning)";
                    SQLiteCommand cm3 = new SQLiteCommand(q3, co3);
                    cm3.Parameters.AddWithValue("@id", id);
                    cm3.Parameters.AddWithValue("@word", r1.GetString(0));
                    cm3.Parameters.AddWithValue("@meaning", mean);
                  //  word = "";
                    mean = "";
                    cm3.ExecuteNonQuery();
                    co3.Close();
                }
                co1.Close();
            }
            catch(SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=indexed.db"))
                {
                    // Be sure you already created the Person Table!

                    conn.Open();

                    var stopwatch = new Timer();
                    stopwatch.Start();

                    using (var cmd = new SQLiteCommand(conn))
                    {
                        using (var con = new SQLiteConnection(@"Data Source=encrypted.db3"))
                        {
                            con.Open();
                            String a = "select * from embed";
                            SQLiteCommand cm = new SQLiteCommand(a, con);
                            SQLiteDataReader eat = cm.ExecuteReader();
                            using (var transaction = conn.BeginTransaction())
                            {
                                // 100,000 inserts


                                // MessageBox.Show("fg");
                                while (eat.Read())
                                {
                                    cmd.CommandText = "INSERT INTO good (word) VALUES ('" + eat.GetString(1) + "');";
                                    cmd.ExecuteNonQuery();

                                }

                                transaction.Commit();
                            }
                        }

                        MessageBox.Show(timer1.Interval.ToString());

                        conn.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
              
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String mean = "";
                int id = 54474;
                OdbcConnection co1=new OdbcConnection("DSN=it");
                co1.Open();
               // co1.BeginTransaction();
                string q1 = "select * from tab";
               OdbcCommand cm1=new OdbcCommand(q1,co1);
                OdbcDataReader r1=cm1.ExecuteReader();
                while (r1.Read())
                {
                    id = id + 1;

                    // MessageBox.Show(r1.GetString(0));
                    //SQLiteConnection co2 = new SQLiteConnection("Data Source=data2.db3");
                    //co2.Open();

                    ////MessageBox.Show(r1.GetString(0));
                    //string q2 = string.Format("select meaning from embed where word='{0}'", r1.GetString(0));
                    //SQLiteCommand cm2 = new SQLiteCommand(q2, co2);
                    //SQLiteDataReader r2 = cm2.ExecuteReader();
                    //while (r2.Read())
                    //{
                    //    //word += r2.GetString(1);


                    //    mean += r2.GetString(0) + "\n";

                    //}
                    //// MessageBox.Show(mean.ToString());
                    //co2.Close();
                    try
                    {
                        SQLiteConnection co3 = new SQLiteConnection("Data Source=encrypted.db3");
                        co3.Open();
                        string q3 = "insert into embed(id,word,meaning)values(@id,@word,@meaning)";
                        SQLiteCommand cm3 = new SQLiteCommand(q3, co3);
                        cm3.Parameters.AddWithValue("@id", id);
                        cm3.Parameters.AddWithValue("@word", r1.GetString(0));
                        cm3.Parameters.AddWithValue("@meaning", r1.GetString(1));
                        //  word = "";
                        //mean = "";
                        cm3.ExecuteNonQuery();
                        co3.Close();
                    }
                    catch {}
                }
                co1.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //public string ImageToBase64(Image image,System.Drawing.Imaging.ImageFormat format)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        // Convert Image to byte[]
        //        image.Save(ms, format);
        //        byte[] imageBytes = ms.ToArray();

        //        // Convert byte[] to Base64 String
        //        string base64String = Convert.ToBase64String(imageBytes);
        //        return base64String;
        //    }
        //}
        //public Image Base64ToImage(string base64String)
        //{
        //    // Convert Base64 String to byte[]
        //    byte[] imageBytes = Convert.FromBase64String(base64String);
        //    MemoryStream ms = new MemoryStream(imageBytes, 0,
        //      imageBytes.Length);

        //    // Convert byte[] to Image
        //    ms.Write(imageBytes, 0, imageBytes.Length);
        //    Image image = Image.FromStream(ms, true);
        //    return image;
        //}
    }
}
