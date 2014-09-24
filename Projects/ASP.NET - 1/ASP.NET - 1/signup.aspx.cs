using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Odbc;
using ASP.NET___1;

namespace ASP.NET___1
{
    public partial class WebForm1 : System.Web.UI.Page 
    {
        public cryptography ct = new cryptography();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            
            // RadioButton1.Checked = true
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void ListView1_Disposed(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
         //   RadioButton2.Enabled = false;
          
           
        }

        protected void Button1_Click1(object sender, EventArgs e) 
        {
          
            try
            {
                string ss = DropDownList3.Text + "-" + DropDownList2.Text + "-" + DropDownList1.Text;
                if (RadioButton1.Checked == true)
                {
                    string url = "INSERT INTO sam(name, dob, gender, religion, nationality, community, mothertongue, nativestate, hostel, bloodgroup, mobileno, email) VALUES('" + ct.encrypt(TextBox1.Text.ToString()) + "','" + ss + "','" + RadioButton1.Text + "','" + DropDownList9.Text + "','" + DropDownList4.Text + "','" + DropDownList6.Text + "','" + DropDownList7.Text + "','" + DropDownList10.Text + "','" + DropDownList8.Text + "','" + DropDownList5.Text + "','" + TextBox4.Text + "','" + ct.encrypt(TextBox3.Text.ToString()) + "')";
                    OdbcConnection connection = new OdbcConnection("DSN=prabakaran");
                    connection.Open();
                    OdbcCommand ocd = new OdbcCommand(url, connection);
                    ocd.ExecuteNonQuery();
                    connection.Close();
                  
                   
                    Response.Redirect("~/welcome.aspx");
                    
                }
                else
                {
                    string url = "INSERT INTO sam(name, dob, gender, religion, nationality, community, mothertongue, nativestate, hostel, bloodgroup, mobileno, email) VALUES('" + ct.encrypt(TextBox1.Text.ToString()) + "','" + ss + "','" + RadioButton2.Text + "','" + DropDownList9.Text + "','" + DropDownList4.Text + "','" + DropDownList6.Text + "','" + DropDownList7.Text + "''," + DropDownList10.Text + "','" + DropDownList8.Text + "','" + DropDownList5.Text + "','" + TextBox4.Text + "','" + ct.encrypt(TextBox3.Text.ToString()) + "')";
                    OdbcConnection connection = new OdbcConnection("DSN=prabakaran");
                    connection.Open();
                    OdbcCommand ocd = new OdbcCommand(url, connection);
                    ocd.ExecuteNonQuery();
                    connection.Close();

                    Response.Redirect("~/welcome.aspx");
                }
               
            }
            catch (Exception ex)
            {
               
                Response.Write(ex.Message);

             
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            //RadioButton1.Enabled = false;
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {
        
        }

        protected void DropDownList9_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        protected void DropDownList10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

      
    }
}