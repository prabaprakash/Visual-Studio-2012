using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Microsoft.Phone.Data.Linq;
using Microsoft.Phone.Data.Linq.Mapping;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows_Phone_Learn.Resources;
using Community.CsharpSqlite.SQLiteClient;

namespace Windows_Phone_Learn
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
           
            //try
            //{
             //   var file = await Windows.StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appdata:///local/encrypted.db3"));

                //DataContext db = new BooksDataContext("isostore:/encrypted.sdf");
                //textbox1.Text = "done";
                //if (!db.DatabaseExists())
                //    db.CreateDatabase();
                
            //}
            //catch (Exception ex)
            //{
            //    //textbox1.Text = "wasre"+ex.Message;
            //}
            //// Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //textbox1.Text = "Praba";
            try
            {
                textbox2.Text = "passed";
                String d = "encrypted.db";
                SqliteConnection a = new SqliteConnection(d);
                textbox2.Text = "passes2";
                
                a.Open();
                String aa = @"select distinct * from embed where word='" + textbox1.Text + "'";
                SqliteCommand sc = new SqliteCommand(aa, a);
                SqliteDataReader reade = sc.ExecuteReader();
                while (reade.Read())
                {
                    textbox2.Text = reade.GetString(2);
                }
                a.Close();
            }
            catch (Exception ex)
            {
                textbox1.Text = ex.Message;
            }
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //public class BooksDataContext : DataContext
        //{
        //    public Table<embed> embed;

        //   public BooksDataContext(string connection) : base(connection) { }
        //}
        //[Table]
        //public class embed
        //{
        //    [Column(IsPrimaryKey = true)]
        //    public Int32 id { get; set; }
        //    [Column]
        //    public String word { get; set; }
        //    [Column]
        //    public String meaning { get; set; }
        //}
       

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}