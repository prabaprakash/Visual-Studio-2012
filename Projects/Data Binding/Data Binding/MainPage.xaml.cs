using System;
using System.Collections.Generic;
using System.IO;
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
using Windows.Data.Json;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Data_Binding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            text1.DataContext = new praba("praba","hide");
            text2.DataContext = new prabas("praba2", "hide");

        }
        public class praba
        {

            string a { get; set; }
             string b{get;
                 set;
             }
            praba() { }
            public  praba(string c, string d)
            {
                this.a = c;
                this.b = d;
            }
            public override string ToString()
            {
                return a + b;
            }
        }
        public class prabas
        {

            string a { get; set; }
            string b
            {
                get;
                set;
            }
            prabas() { }
            public prabas(string c, string d)
            {
                this.a = c;
                this.b = d;
            }
            public override string ToString()
            {
                return a + b;
            }

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void addlistitems(object sender, RoutedEventArgs e)
        {
            list1.Items.Add(DataContext =new praba("fdf", "gdfg"));
            Image image = new Image();
            image.Source =new BitmapImage(new Uri(@"ms-appx:/Assets/Logos/Logo.png"));
            list1.Items.Add(image);
            MessageDialog a = new MessageDialog("Removeall","Remove");
            a.Commands.Add(new UICommand("Donotinstall",null,1));
           
            await a.ShowAsync();
            var messageDialog = new MessageDialog("No internet connection has been found.");

            // Add commands and set their callbacks; both buttons use the same callback function instead of inline event handlers
            messageDialog.Commands.Add(new UICommand("Try again", new UICommandInvokedHandler(this.CommandInvokedHandler)));
            messageDialog.Commands.Add(new UICommand("Close", new UICommandInvokedHandler(this.CommandInvoked)));

            // Set the command that will be invoked by default
            messageDialog.DefaultCommandIndex = 0;

            // Set the command to be invoked when escape is pressed
            messageDialog.CancelCommandIndex = 1;

            // Show the message dialog
            await messageDialog.ShowAsync();

        }
        private void CommandInvokedHandler(IUICommand command)
        {
            // Display message showing the label of the command that was invoked
            list1.Items.Add("try again");
           
        }
        private void CommandInvoked(IUICommand command)
        {
            // Display message showing the label of the command that was invoked
            list1.Items.Add("close");
        }
    }
}
