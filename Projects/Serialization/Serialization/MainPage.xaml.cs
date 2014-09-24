using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Serialization
{
    using System.Xml.Serialization;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.SizeChanged += MainPage_SizeChanged;
        }

        void MainPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ApplicationViewState Aps = ApplicationView.Value;
            VisualStateManager.GoToState(this, Aps.ToString(), false);
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            List<MyClass> ls = new List<MyClass>()
                {
                    new MyClass
                        {
                            _id = 1108,
                            _name = "Praba",
                           
                        },
                    new MyClass
                        {
                            _id = 1133,
                            _name = "Sam",
                            
                        },
                    new MyClass
                        {
                            _id = 3,
                            _name = "Praveen",
                         
                        }
                };

       
            string g = JsonConvert.SerializeObject(ls, Formatting.Indented);
           // var h = JsonConvert.DeserializeObject<MyClass>(g);

            StorageFile cFile=await  ApplicationData.Current.LocalFolder.CreateFileAsync("jsonFile.txt", CreationCollisionOption.OpenIfExists);
            using (var sWriter=new StreamWriter(await cFile.OpenStreamForWriteAsync()))
            {
                sWriter.Write(g);
                await sWriter.FlushAsync();
            }
            var rFile = await ApplicationData.Current.LocalFolder.GetFileAsync("jsonFile.txt");
            String fString=null;
            using (var sReader=new StreamReader(await  rFile.OpenStreamForReadAsync()))
            {
                fString=await sReader.ReadToEndAsync();
            }

            if (fString != null)
            {
                var ls2 = JsonConvert.DeserializeObject<List<MyClass>>(fString);
                txt.Text = "";
                var query = from x in ls2 where x.Name.Equals("Praba") select x;
                foreach (var d in query)
                {
                    Debug.WriteLine(d.Id+"\n"+ d.Name + "\n");
                    txt.Text += d.Id + "\n" + d.Name + "\n";
                }
                Debug.WriteLine("Well !!!... Its Working......");
            }
            new MessageDialog(g.ToString()).ShowAsync();


        }
        public class MyClass
        {
            public int _id;
            public String _name;
            
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public String Name
            {
                get { return _name; }
                set { _name = value; }
            }

            
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // MyClass my = new MyClass() { _id = 3, _name = "Praba" };
           // XmlSerializer xml=new XmlSerializer(my.GetType());
           // StorageFile sf = await ApplicationData.Current.LocalFolder.CreateFileAsync("file.txt");
            
           //string f= xl.Serialize()
           

        }

    }
}
