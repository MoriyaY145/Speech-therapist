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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace speechTherapist
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class page_change : Page
    {
        public page_change()
        {
            this.InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page6));
        }

        private void sym1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_4));
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page1));
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.2;
            p1.IsOpen = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_change));
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_change));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_4));
        }
    }
}
