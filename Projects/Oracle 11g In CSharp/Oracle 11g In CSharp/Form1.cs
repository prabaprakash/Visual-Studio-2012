using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Odbc;

namespace Oracle_11g_In_CSharp
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
                OdbcConnection oc = new OdbcConnection("DSN=prabakaran");
                string a="select * from sam";
                oc.Open();
                OdbcCommand com = new OdbcCommand(a, oc);
                OdbcDataReader dd = com.ExecuteReader();
                MessageBox.Show(dd.GetName(0));
                
                while (dd.Read())
                {
                    ListViewItem aa = new ListViewItem(dd.GetString(0));
                    listView1.Items.Add(aa);
                    
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
