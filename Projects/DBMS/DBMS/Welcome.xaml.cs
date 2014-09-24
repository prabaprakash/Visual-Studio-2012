using System;
using System.Collections.Generic;
using System.Data.Odbc;
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


namespace DBMS
{
    
 
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Window
    {
        public cryptography ct = new cryptography();
        public String mail;
        public Welcome()
        {
         
            InitializeComponent();
           
            //  list1.Items.Add(new NamePhone("ff","fdf"));
        }
        public void praba()
        {
            try
            {
                OdbcConnection connection = new OdbcConnection("DSN=prabakaran");
                connection.Open();

                string url = "select * from candidat where emailid='"+ct.encrypt(mail)+"';";
                MessageBox.Show("Wait");

                OdbcCommand oc = new OdbcCommand(url, connection);
                OdbcDataReader a = oc.ExecuteReader();
                while ( a.Read())
                {


                    // MessageBox.Show(a.GetName(0), a.GetInt32(0).ToString());
                    // list1.Items.Add(new NamePhone());
                  // list1.Items.Add(new NamePhone(a.GetName(0), a.GetDecimal(0).ToString()));
                    list1.Items.Add(new NamePhone(a.GetName(1), ct.decrypt(a.GetString(1))));
                    list1.Items.Add(new NamePhone(a.GetName(2), a.GetString(2)));
                    list1.Items.Add(new NamePhone(a.GetName(3), a.GetString(3)));
                    list1.Items.Add(new NamePhone(a.GetName(4), a.GetString(4)));
                    list1.Items.Add(new NamePhone(a.GetName(5), a.GetString(5)));
                    list1.Items.Add(new NamePhone(a.GetName(6), a.GetString(6)));
                    list1.Items.Add(new NamePhone(a.GetName(7), a.GetString(7)));
                    list1.Items.Add(new NamePhone(a.GetName(8), a.GetString(8)));
                    list1.Items.Add(new NamePhone(a.GetName(9), a.GetString(9)));

                    list1.Items.Add(new NamePhone(a.GetName(10), a.GetString(10)));
                    list1.Items.Add(new NamePhone(a.GetName(11), a.GetString(11)));
                    list1.Items.Add(new NamePhone(a.GetName(12), a.GetString(12)));
                    list1.Items.Add(new NamePhone(a.GetName(13), a.GetString(13)));
                    list1.Items.Add(new NamePhone(a.GetName(14), ct.decrypt(a.GetString(14))));
                    list1.Items.Add(new NamePhone(a.GetName(15), a.GetString(15)));
                    list1.Items.Add(new NamePhone(a.GetName(16), a.GetString(16)));
                    list1.Items.Add(new NamePhone(a.GetName(17), a.GetString(17)));

                    list1.Items.Add(new NamePhone(a.GetName(18), a.GetString(18)));
                    list1.Items.Add(new NamePhone(a.GetName(19), a.GetString(19)));
                    list1.Items.Add(new NamePhone(a.GetName(20), a.GetString(20)));
                }
            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public struct NamePhone
        {
            public NamePhone(string _name, string _phone)
            {
                name = _name;
                phone = _phone;
            }

            string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            string phone;
            public string Phone
            {
                get { return phone; }
                set { phone = value; }
            }
        }


        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void load_Loaded(object sender, RoutedEventArgs e)
        {
            praba();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
        }

        private void load_Closed(object sender, EventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Hide();
        }
    }
}
