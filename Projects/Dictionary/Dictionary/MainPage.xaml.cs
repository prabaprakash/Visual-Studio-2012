using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Microsoft.Phone.Data.Linq.Mapping;
using System.Net;
using System.IO;
using System.Windows;
using Windows.Storage;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Dictionary.Resources;

namespace Dictionary
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            try
            {
               // ProjectFile();
                DataContext db =
         new embedsDataContext("isostore:/encrypted.sdf");
                if (!db.DatabaseExists())
                    db.CreateDatabase();
            }
            catch

            { }

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        public class embedsDataContext : DataContext
        {  
            

        
            public Table<embed> embeds;
        
            public embedsDataContext(string connection)
                : base(connection) { }
        
   
        }
        public async void ProjectFile()
        {
            //settings
            try
            {
                var uri = new Uri("ms-appx:///encrypted.sdf");
                var file = await StorageFile.GetFileFromApplicationUriAsync(uri);

                var destinationFolder = ApplicationData.Current.LocalFolder;


                // var f = await destinationFolder.GetFileAsync("encrypted.db3");

                await file.CopyAsync(destinationFolder);
            }

            catch (Exception ex)
            {
                if (ex.Message.Equals("Cannot create a file when that file already exists. (Exception from HRESULT: 0x800700B7)"))
                {
                    textbox1.Text = "";
                }
                else
                {
                    textbox1.Text = ex.Message;
                }
            }
        }
        [Table]
        public class embed
        {
            [Column(IsPrimaryKey = true)]
            public int id{ get; set; }

            [Column]
            public string word { get; set; }

            [Column]
            public string meaning { get; set; }

           
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                embedsDataContext db =
      new embedsDataContext("isostore:/encrypted.sdf");

                embed pub = new embed()
                {
                    id=1,
                    word = "Prabakaran.a",
                    meaning = "Studying Ms Software Engineering(2011-2016),Vit Chennai Campus",

                };

                db.embeds.InsertOnSubmit(pub);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                textbox1.Text = ex.Message;
            }
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               // var dbpath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "encrypted.db3");
                embedsDataContext db =new embedsDataContext("isostore:/encrypted.sdf");
                var q = from b in db.embeds
                        orderby b.word
                        select b;
                foreach (var stoch in q)
                {
                    textbox1.Text = stoch.meaning.ToString();
                }
            }
            catch(Exception ex)
            {
                textbox1.Text = ex.Message;
            }

        }

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