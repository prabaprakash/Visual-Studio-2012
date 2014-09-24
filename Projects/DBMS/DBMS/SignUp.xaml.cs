using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Odbc;
namespace DBMS
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window 
    {
        public String gender;
       public cryptography cdd = new cryptography();
        public SignUp()
        {
            InitializeComponent();
            Random a = new Random();
            block1.Text = a.Next(4444, 8888).ToString();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (radio1.IsChecked == true)
            {
                radio2.IsChecked = false;
               
                gender = "Male";
            }

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            if (radio2.IsChecked == true)
            {
                radio1.IsChecked = false;
                
                gender = "Female";
            }
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
            //if (datepicker1.SelectedDate.Value !=null)
            //{
            //    MessageBox.Show(datepicker1.SelectedDate.Value.ToShortDateString());
            //}
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           // name = "";
           // name = txt1.Text;
           //// MessageBox.Show(name);
          
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random a = new Random();
            block1.Text = a.Next(4444, 8888).ToString();
        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            //religion = "";
            //religion = combo1.SelectedItem.ToString();
            ////MessageBox.Show(combo1.se));
        }

        private async void button1_Click(object sender, RoutedEventArgs e)
        {
          //  MessageBox.Show(religion.SelectionBoxItem.ToString());
            if (name.Text == "")
            {
                MessageBox.Show("Enter the Name");

            }
            else if (gender == "")
            {
                MessageBox.Show("Select gender");
            }
            //else if (datepicker1.SelectedDate.Value.ToString() == "12-31-1997")
            //{
            //    MessageBox.Show("Select the Date of Birth");
            //}
            else if (religion.SelectionBoxItem.ToString() == "")
            {
                MessageBox.Show("Select the religion");
            }
            else if (community.SelectionBoxItem.ToString() == "")
            {
                MessageBox.Show("Select the community");
            }
            else if (nationality.SelectionBoxItem.ToString() == "")
            {
                MessageBox.Show("Select the Nationality");
            }
            else if (address.Text == "")
            {
                MessageBox.Show("Enter the Address");
            }
            else if (city.Text == "")
            {
                MessageBox.Show("Enter the City");
            }
            else if (state.Text == "")
            {
                MessageBox.Show("Enter the State");
            }
            else if (pincode.Text == "")
            {
                MessageBox.Show("Enter the Pincode");
            }
            else if (country.Text == "")
            {
                MessageBox.Show("Enter the Country Name");
            }
            else if (bloodgroup.SelectionBoxItem.ToString() == "")
            {
                MessageBox.Show("Select the Blood group");
            }
            else if (mobileno.Text == "")
            {
                MessageBox.Show("Eneter the Mobile No");
            }
            else if (emailid.Text == "")
            {
                MessageBox.Show("Enter the Mail ID");
            }
            else if (boardofexam.SelectionBoxItem.ToString() == "")
            {
                MessageBox.Show("Select the board of exam");
            }
            else if (yearofpassing.Text == "")
            {
                MessageBox.Show("Enter the passing year");
            }
            else if (grade.Text == "")
            {
                MessageBox.Show("enter the grade");
            }
            else if (mediumofinstruction.Text == "")
            {
                MessageBox.Show("Enter the medium of instruction");
            }
            else if (schoolname.Text == "")
            {
                MessageBox.Show("enter the school name");
            }
            else if (qualification.Text == "")
            {
                MessageBox.Show("enter the qualified exam");
            }
            else if (boardname.Text == "")
            {
                MessageBox.Show("enter the board name");
            }
            else if(sec.Text.ToString()!=block1.Text.ToString())
            {
                Random a = new Random();
                block1.Text = a.Next(4444, 8888).ToString();
                MessageBox.Show("Wrong Secuirty Code");

            }
            else
            {
                try
                {

                    await xeroundplay();
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }

        }

        private async Task xeroundplay()
        {
            OdbcConnection a = new OdbcConnection("DSN=prabakaran");
            a.Open();
            String g, i;
            Random ad = new Random();
            int cid = ad.Next(1, 10000);
            // h = "(cid,name,dob,gender,religion,community,nationality,address,city,state,pincode,country,bloodgroup,mobileno,emailid,boardofexam,yearofpassing,grade,mediumofinstruct,schoolname,qualifyingexam,boardname)";";
            g = "insert into candidat(cid,name,dob,gender,religion,community,nationality,address,city,state,pincode,country,bloodgroup,mobileno,emailid,boardofexam,yearofpassing,grade,mediumofinstrut,schoolname,qualifyingexam,boardname)";
            // + cid + ",'" + name.Text + "','" + datepicker1.SelectedDate.Value.ToString()+ "','" + gender.ToString() + "','" + religion.SelectionBoxItem.ToString() + "','" + community.SelectionBoxItem.ToString() + "','" + nationality.SelectionBoxItem.ToString() + "','" + address.ToString() + "','" + city.ToString() + "','" + state.ToString() + "','" + Int16.Parse(pincode.ToString()) + "','" + country.ToString() + "','" + bloodgroup.SelectionBoxItem.ToString() + "','" +Int32.Parse(mobileno.ToString())+ "','" + emailid.ToString() + "','" + boardofexam.SelectionBoxItem.ToString() + "','" + Int32.Parse(yearofpassing.ToString()) + "','" + grade.ToString() + "','" + mediumofinstruction.ToString() + "','" + schoolname.ToString() + "','" + qualification.ToString() + "','" + boardname.ToString()+ 
            i = "values(" + cid.ToString() + ",'" + cdd.encrypt(name.Text.ToString()) + "','" + datepicker1.SelectedDate.Value.ToString() + "','" + gender.ToString() + "','" + religion.SelectionBoxItem.ToString() + "','" + community.SelectionBoxItem.ToString() + "','" + nationality.SelectionBoxItem.ToString() + "','" + address.Text.ToString() + "','" + city.Text.ToString() + "','" + state.Text.ToString() + "','" + pincode.Text.ToString() + "','" + country.Text.ToString() + "','" + bloodgroup.SelectionBoxItem.ToString() + "','" + mobileno.Text.ToString() + "','" + cdd.encrypt(emailid.Text.ToString()) + "','" + boardofexam.SelectionBoxItem.ToString() + "','" + yearofpassing.Text.ToString() + "','" + grade.Text.ToString() + "','" + mediumofinstruction.Text.ToString() + "','" + schoolname.Text.ToString() + "','" + qualification.Text.ToString() + "','" + boardname.Text.ToString() + "');";

            OdbcCommand cn = new OdbcCommand(g + i, a);
            await cn.ExecuteNonQueryAsync();
            a.Close();
            MessageBox.Show("Account Created Successflly");
            Welcome we = new Welcome();
            we.mail = emailid.Text.ToString();
            we.Show();
            this.Hide();
        }

        private void mediumofinstruction_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
            
        }
    }
}
