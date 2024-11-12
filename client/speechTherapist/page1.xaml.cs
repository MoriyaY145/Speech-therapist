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
    public sealed partial class page1 : Page
    {
        Service1Client client = new Service1Client();
        List<treatment> treatments = null;
        public page1()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_3));
        }

        private void CalendarViewDayItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pageAgain));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page1));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }
    }
}
