using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Developing_Styles
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Application.Current.Resuming += Current_Resuming;
            Application.Current.Suspending += Current_Suspending;
            Application.Current.UnhandledException += Current_UnhandledException;


        }

      async  private void Current_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
             await new MessageDialog("hello").ShowAsync();
        }

       async private void Current_Suspending(object sender, Windows.ApplicationModel.SuspendingEventArgs e)
        {
             await new MessageDialog("hello").ShowAsync();
        }

     async   private void Current_Resuming(object sender, object e)
     {
         await new MessageDialog("hello").ShowAsync();
     }
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
          
        }
    }
}
