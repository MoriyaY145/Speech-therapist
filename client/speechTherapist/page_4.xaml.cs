using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using speechTherapist.ServiceReference2;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace speechTherapist
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class page_4 : Page
    {
        Service1Client client = new Service1Client();
        List<metupal> metupals = new List<metupal>();
        string kupach = "מאוחדת";
        metupal M = null;
        public page_4()
        {
            this.InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {
            metupals = await client.GetAllMetupalAsync();
            lView1.ItemsSource = metupals.Where(x=> x.kupat_cholim == kupach).ToList();
        }
        private void tbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            lView1.ItemsSource = metupals.Where(x => x.name_metupal.StartsWith(tbox1.Text));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_3));
        }
            //if(M!=null)
        private void lView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            M = lView1.SelectedItem as metupal;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_4));
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_4));
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_4));
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.2;
            p1.IsOpen = true;
            p2.IsOpen = false;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page6),M);
        }

        private void sPanel1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Opacity = 0.2;
            p2.IsOpen = true;
        }
    }
}
