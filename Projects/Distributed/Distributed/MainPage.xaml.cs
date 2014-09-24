using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;


namespace Distributed
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
         private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random a = new Random();
            block1.Text = a.Next(4444, 8888).ToString();
        }
         private void Button_Click_1(object sender, RoutedEventArgs e)
         {
             //ChildWindow1 a = new ChildWindow1();
             //a.Show();
             Page1 a = new Page1();
             this.Content = a;
            
             //this.NavigationService.Navigate(new Uri("/OtherPage.xaml", UriKind.Relative));

          //   this.NavigationService.Navigate(new Uri("SelectionPage.xaml", UriKind.Relative));

             //System.Windows.Browser.HtmlPage.Window.Navigate( new Uri("Page1.xaml"), "_blank" );
           
         }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
         
            if (textBox1.Text == "")
            {
                passbox1.Password = "";
                textBox2.Text = "";
                Random a = new Random();
                block1.Text = a.Next(4444, 8888).ToString();
                MessageBox.Show("Enter The UserName");

            }
            else if (passbox1.Password.ToString() == "")
            {
                
                Random a = new Random();
                block1.Text = a.Next(4444, 8888).ToString();
                MessageBox.Show("Enter The Password");
            }
            else if (textBox2.Text != block1.Text)
            {
                passbox1.Password = "";
                textBox2.Text = "";
                Random a = new Random();
                block1.Text = a.Next(4444, 8888).ToString();
                MessageBox.Show("Verification Code InCorrect");
               
            }
            if (textBox1.Text != "" && passbox1.Password.ToString() != "" && textBox2.Text.ToString() == block1.Text.ToString())
            {
                try
                {
                    //int c = 0;
                    //OdbcConnection connection = new OdbcConnection("DSN=prabakaran");
                    //connection.Open();

                    //string url = "select distinct emailid,mobileno from candidat where mobileno='" + passbox1.Password.ToString() + "' and emailid='" + textBox1.Text + "'" + " ;";

                    //OdbcCommand oc = new OdbcCommand(url, connection);
                    //OdbcDataReader a = oc.ExecuteReader();
                    //while (a.Read())
                    //{
                    //    c++;
                    //}


                    //if (c == 1)
                    //{
                    //    connection.Close();


                    //    MessageBox.Show("Login Sccessfully");
                    //    Welcome aa = new Welcome();
                    //    aa.mail = textBox1.Text.ToString();
                    //    // DBMS.Properties.Settings.Default.name = textBox1.Text.ToString();
                    //    aa.Show();
                    //    this.Hide();

                    //}
                    //else
                    //{
                    //    passbox1.Password = "";
                    //    textBox2.Text = "";
                    //    Random f = new Random();
                    //    block1.Text = f.Next(4444, 8888).ToString();
                    //    MessageBox.Show("Username And Password Is Wrong.\nTry Again");
                    //    connection.Close();

                    //}


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void navigate_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
           
        }
    }
}
