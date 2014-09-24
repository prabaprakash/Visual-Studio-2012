using System;
//using Sqlite_For_Windows_8_Metro.Common;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sqlite_For_Windows_8_Metro
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class learn : Common.LayoutAwarePage
    {
        public learn()
        {
            this.InitializeComponent();
            // Window.Current.SizeChanged+=(object sender,Windows.UI.Core.WindowSizeChangedEventArgs e)=>
            // {
            //switch (Windows.UI.ViewManagement.ApplicationView.Value)
            //{
            //    case Windows.UI.ViewManagement.ApplicationViewState.Filled:
            //        VisualStateManager.GoToState(this, "Fill", false);
            //        break;
            //    case Windows.UI.ViewManagement.ApplicationViewState.FullScreenLandscape:
            //        VisualStateManager.GoToState(this, "Full", false);
            //        break;
            //    case Windows.UI.ViewManagement.ApplicationViewState.Snapped:
            //        VisualStateManager.GoToState(this, "Snapped", false);
            //        break;
            //    case Windows.UI.ViewManagement.ApplicationViewState.FullScreenPortrait:
            //        VisualStateManager.GoToState(this, "Portrait", false);
            //        break;
            //    default:
            //        break;
            //}
            //this.ShowCurrentViewState();
            //};
            
        }

        private void ShowCurrentViewState()
        {
            throw new NotImplementedException();
        }
       
       
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
