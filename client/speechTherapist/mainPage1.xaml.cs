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
    public sealed partial class mainPage1 : Page
    {
        ServiceReference2.Service1Client client = new ServiceReference2.Service1Client();
        public mainPage1()
        {
            this.InitializeComponent();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int p = 1234;
            string s = "ציפי יגודייב";
            if(tbox2.Password ==p.ToString() && tbox1.Text == s)
            this.Frame.Navigate(typeof(page_2));
            else
            {
                if (tbox1.Text != s && tbox2.Password == p.ToString())
                {
                    tBlock1.Visibility = Visibility.Visible;
                    btn2.Visibility = Visibility.Visible;
                }
                else
                {
                    if (tbox2.Password != p.ToString() && tbox1.Text == s)
                    {
                        tBlock2.Visibility = Visibility.Visible;
                        btn2.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        tBlock3.Visibility = Visibility.Visible;
                        btn2.Visibility = Visibility.Visible;
                    }
                }
                
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(mainPage1));
        }
    }
}
