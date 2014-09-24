using System;
using System.Runtime.InteropServices;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;



namespace C_Library_in_CSharp
{
  
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        [DllImport("LibraryCDll.dll")]
        public static extern char removeredun(char[] g);
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            String d = "fdfdf";
            var h = d.ToCharArray();
            var a=new char[3];
            String k = null;
            try
            {
             k=removeredun(a).ToString();
            }
            catch (Exception)
            {
                
           
            }
            Button1.Content= k;
        }
    }
}
