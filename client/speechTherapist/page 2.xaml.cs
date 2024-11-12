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
    public sealed partial class page_2 : Page
    {
        public page_2()
        {
            this.InitializeComponent();
        }

        private void sym1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mainPage1));
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page1));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_3));
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page6));
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.2;
            p1.IsOpen = true;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_8));
        }
    }
}
