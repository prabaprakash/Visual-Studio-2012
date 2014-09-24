//Prabakaran.A
//MS Software Engineering (2011-2016)
//VIT University - Chennai Campus
//Tamilnadu State
//India - 600 048
//www.facebook.com/prabakaran1993
using System;
using System.Collections.Generic;
using System.IO; //for specify path -> namespace
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using SQLite; // for sqlite namespace
using System.Diagnostics;
using System.ComponentModel;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.ViewManagement;
using Windows.UI.Popups; //for message dialog -> namespace
using Buddy;


//Prabakaran.A
//MS Software Engineering (2011-2016)
//VIT University - Chennai Campus
//Tamilnadu State
//India - 600 048
//www.facebook.com/prabakaran1993
namespace Sqlite_For_Windows_8_Metro
{

    public sealed partial class MainPage : Page
    {
        public static string API_LOGIN = "Expert_Tamil_Dictionary"; //Get it from Buddy's site
        public static string API_PASSWORD = "EC071097-379F-4C7E-B132-0604DE7F8D97";

        public MainPage()
        {

            this.InitializeComponent();

            Window.Current.SizeChanged += (object sender, Windows.UI.Core.WindowSizeChangedEventArgs e) =>
    {
        ApplicationViewState myViewState = ApplicationView.Value;

        if (myViewState == ApplicationViewState.Snapped)
        {
            listview1.Margin = new Thickness(1, 0, 0, 0);
        }
        else
        {
            listview1.Margin = new Thickness(419, 10, 0, 0);
        }
    };



        }

        private void MainPage_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }


        //Prabakaran.A
        //MS Software Engineering (2011-2016)
        //VIT University - Chennai Campus
        //Tamilnadu State
        //India - 600 048
        //www.facebook.com/prabakaran1993

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        public class person
        {

            [MaxLength(5), PrimaryKey]

            public String name { get; set; }
            [MaxLength(255)]
            public String address { get; set; }
            [MaxLength(11)]
            public Double phone { get; set; }
        }
        public class kural
        {


            public int kno { get; set; }
            public int kgroup { get; set; }
            [MaxLength(255)]
            public String kuralsection { get; set; }
            [MaxLength(255)]
            public String kural2 { get; set; }
            [MaxLength(255)]
            public String meaning { get; set; }

        }


        private async void createtable(object sender, RoutedEventArgs e)
        {
            try
            {
                var dbpath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "data.db3");
                using (var db = new SQLite.SQLiteConnection(dbpath))
                {
                    // Create the tables if they don't exist
                    db.CreateTable<person>();
                    db.Commit();

                    db.Dispose();
                    db.Close();
                }
                var line = new MessageDialog("Table Created");
                await line.ShowAsync();
            }
            catch
            {

            }
        }

        private async void insert(object sender, RoutedEventArgs e)
        {
            try
            {

                if (txt1.Text != "" && txt2.Text != "" && txt3.Text != "")
                {
                    var dbpath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "data.db3");
                    using (var db = new SQLite.SQLiteConnection(dbpath))
                    {
                        // Create the tables if they don't exist
                        db.Insert(new person()
                        {

                            name = txt1.Text.ToString(),
                            address = txt2.Text.ToString(),
                            phone = Convert.ToDouble(txt3.Text.ToString()),
                        }
                        );


                        db.Commit();
                        db.Dispose();
                        db.Close();
                        var line = new MessageDialog("Records Inserted");
                        await line.ShowAsync();
                    }
                }
                else
                {
                    throw new NullReferenceException("Enter The Data In Textboxes");
                    //var line = new MessageDialog("Enter The Data In Textboxes");
                    //await line.ShowAsync();
                }

            }
            catch (SQLiteException)
            {

            }
            catch (NullReferenceException ex)
            {
                list1.Items.Add(ex.Message);
            }
        }

        private async void deleteall(object sender, RoutedEventArgs e)
        {
            var dbpath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "data.db3");
            using (var db = new SQLite.SQLiteConnection(dbpath))
            {
                db.DeleteAll<person>();

            }
            var line = new MessageDialog("All Records Deleted");
            await line.ShowAsync();
        }

        private async void listtable(object sender, RoutedEventArgs e)
        {
            try
            {
                // var uri = new Uri("ms-appx:///EKural.db3");
                // var file = await StorageFile.GetFileFromApplicationUriAsync(uri);

                // var destinationFolder = ApplicationData.Current.LocalFolder;


                // var f = await destinationFolder.GetFileAsync("encrypted.db3");

                //await file.CopyAsync(destinationFolder);
                var dbpath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "EKural.db3");
                using (var db = new SQLite.SQLiteConnection(dbpath))
                {
                    list1.FontFamily = new FontFamily("TAB-LFS-Kamban");

                    //.Distinct<kural>()
                    var parallelquery = from x in db.Table<person>().AsParallel() select x;
                    var takewhile = (from x in db.Table<person>() select x.name).TakeWhile(s => s.Equals("ff"));
                    var take = (from x in db.Table<person>() select x.name).Take(4);
                    var count = (from x in db.Table<person>() select x.name).Count();
                    var distinct = (from x in db.Table<person>() select x.name).Distinct();
                    var startswith = from x in db.Table<person>() where x.name.StartsWith("a") select x;
                    var endswith = from x in db.Table<person>() where x.name.EndsWith("a") select x;
                    var like = from x in db.Table<person>() where x.name.Contains("a") select x;
                    var orderby = from x in db.Table<person>() orderby x.name select x;
                    var groupby = from x in db.Table<person>() group x by x.name into c select new { name = c };
                    //var d =  from x in db.Table<kural>().Distinct<kural>() select x.kuralsection;
                    list1.Items.Clear();
                    foreach (var sd in groupby)
                    {

                        list1.Items.Add(sd.name.ToString());
                        tx1.Text = sd.name.ToString();

                        //list1.Items.Add(sd.address.ToString());
                        //list1.Items.Add(sd.phone.ToString());
                    }
                    //var a = new MessageDialog("gth");

                    //await a.ShowAsync(); 
                    db.Dispose();
                    db.Close();
                }
            }
            catch (SQLiteException a)
            {
                txt1.Text = a.Message;
            }


            //try
            //{
            //    var dbpath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "data.db3");
            //    using (var db = new SQLite.SQLiteConnection(dbpath))
            //    {
            //        var d = from x in db.Table<person>() select x;
            //        list1.Items.Clear();
            //        foreach (var sd in d)
            //        {

            //            list1.Items.Add(sd.name.ToString());
            //            //list1.Items.Add(sd.address.ToString());
            //            //list1.Items.Add(sd.phone.ToString());
            //        }
            //        db.Dispose();
            //        db.Close();
            //    }
            //    var line = new MessageDialog("All Records Listed");
            //    await line.ShowAsync();
            //}
            //catch
            //{
            //}
        }

        private async void drop(object sender, RoutedEventArgs e)
        {
            try
            {
                var dbpath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "data.db3");
                using (var db = new SQLite.SQLiteConnection(dbpath))
                {
                    db.DropTable<person>();
                    db.Dispose();
                    db.Close();

                }
                var line = new MessageDialog("Table Dropped");
                await line.ShowAsync();
            }
            catch
            {
            }
        }

        private void ListView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                txt1.Text = list1.SelectedItem.ToString();

            }
            catch
            {
            }

        }



        private async void deleteselected(object sender, RoutedEventArgs e)
        {


            try
            {
                var dbpath = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "data.db3");
                using (var db = new SQLite.SQLiteConnection(dbpath))
                {
                    db.Delete<person>(list1.SelectedItem.ToString());



                    var d = from x in db.Table<person>() select x;
                    list1.Items.Clear();
                    foreach (var sd in d)
                    {
                        list1.Items.Add(sd.name.ToString());
                        //list1.Items.Add(sd.address.ToString());
                        //list1.Items.Add(sd.phone.ToString());
                    }
                    db.Dispose();
                    db.Close();
                }
                var line = new MessageDialog("Selected Item Deleted");
                await line.ShowAsync();
            }
            catch
            {
            }

        }

        private void LayoutRoot_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            //if (e.Key == Windows.System.VirtualKey.F)
            //{
            //    txt1.Text += e.Key.ToString();
            //}
            //else if (e.Key == Windows.System.VirtualKey.Up)
            //{
            //    list1.SelectedIndex = (list1.SelectedIndex + 1);
            //}
        }

        private void txt2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                BuddyClient a = new BuddyClient(API_LOGIN, API_PASSWORD);
                //a.CreateUserAsync((user, state) =>
                //{
                //    //Check that creation succeeded
                //    if (state.Exception != null) txt1.Text=("CreateUserAsync Error: " + state.Exception.Message + " " + state.Exception.StackTrace);

                //}, name: "prab", password: "sam",
                //    //All of the arguments below are optional
                //   gender: UserGender.Male,
                //   age: 37, email: "praba@gmail.com",
                //   status: UserStatus.Engaged,
                //   fuzzLocation: false,
                //   celebrityMode: false,
                //   appTag: "WinSDKDocApp",
                //   state: string.Empty
                //   );
                //a.LoginAsync((user, s2) =>
                //{
                //    user.PushNotifications.Win8.SendTileAsync((result, s1) =>
                //    {
                //        //Check the Result
                //    }, xmlPayload: "<#Payload#>", senderUserId: user.ID, deliverAfter: DateTime.Now, groupName: "", state: null);
                //}, token: Token, state: null);
                //var line = new MessageDialog(a.AppName.ToString());
                //await line.ShowAsync();
            }
            catch (BuddyServiceException ex)
            {
                txt1.Text = ex.Message.ToString();
            }
        }

        private void LayoutRoot_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            //    if (e.Key == Windows.System.VirtualKey.F)
            //    {
            //        txt1.Text += e.Key.ToString();
            //    }
            //    else if (e.Key == Windows.System.VirtualKey.Up)
            //    {
            //        list1.SelectedIndex = (list1.SelectedIndex - 1);
            //    }
            //    else if (e.Key == Windows.System.VirtualKey.Down)
            //    {
            //        list1.SelectedIndex= (list1.SelectedIndex + 1);
            //    }
        }

        private void tx1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tx1_KeyDown(object sender, KeyRoutedEventArgs e)
        {

        }

        private void tx1_KeyUp(object sender, KeyRoutedEventArgs e)
        {

        }

        private void Page_KeyDown_1(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.F)
            {
                txt1.Text += e.Key.ToString();
            }
            else if (e.Key == Windows.System.VirtualKey.Up)
            {
                list1.SelectedIndex = (list1.SelectedIndex + 1);
            }
        }

        public async void button123(object sender, RoutedEventArgs e)
        {
            var line = new MessageDialog("hide and seek");
            await line.ShowAsync();

            learn a = new learn();
            Window.Current.Content = a;


        }

        //Prabakaran.A
        //MS Software Engineering (2011-2016)
        //VIT University - Chennai Campus
        //Tamilnadu State
        //India - 600 048
        //www.facebook.com/prabakaran1993
    }
}
