using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace ASP.NET___1
{
    public partial class login : System.Web.UI.Page
    {
        public cryptography ct = new cryptography();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text == "")
            {
                Response.Write("Enter The UserName");
            }
            else if (TextBox2.Text == "")
            {
                Response.Write("Enter The Password");
            }
           
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                try
                {
                    int c = 0;
                    OdbcConnection connection = new OdbcConnection("DSN=prabakaran");
                    connection.Open();

                    string url = "select distinct mobileno,email from sam where mobileno='" + TextBox2.Text + "' and email='" + ct.encrypt(TextBox1.Text.ToString()) +"'" + " ;";

                    OdbcCommand oc = new OdbcCommand(url, connection);
                    OdbcDataReader a = oc.ExecuteReader();
                    while (a.Read())
                    {
                        c++;
                    }


                    if (c == 1)
                    {
                        connection.Close();
                       Response.Redirect("~/welcome.aspx");

                       
                    }
                    else
                    {
                        Response.Write("Username And Password Is Wrong.\nTry Again");
                        connection.Close();
                    }

                }
                catch (Exception ex)
                {
                   Response.Write(ex.Message);

                }
            }
        }
    }
}