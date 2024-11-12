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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace speechTherapist
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void tb6_Click(object sender, RoutedEventArgs e)
        {
            a1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            c3.Visibility = Visibility.Visible;
            d4.Visibility = Visibility.Visible;
            e5.Visibility = Visibility.Visible;
            f6.Visibility = Visibility.Visible;
        }

        private void f6_Click(object sender, RoutedEventArgs e)
        {
            TextBox t = new TextBox
            {
                Width=496,FontSize=22
            };
            sPanel.Children.Add(t);
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }
    }
}
