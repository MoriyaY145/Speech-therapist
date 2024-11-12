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
    public sealed partial class page5 : Page
    {
        Service1Client client = new Service1Client();
        List<treatment> treatments = null;
        public page5()
        {
            this.InitializeComponent();
        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {

            treatments = await client.GetTreatmentAsync();
            //lView1.ItemsSource = treatments;
            foreach (treatment item in treatments)
            {
                StackPanel sPanel = new StackPanel();
                sPanel.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(100, 50, 50, 50));
                //הכנת הפקדים
                TextBlock t = new TextBlock();
                t.Text = item.code_metupal.name_metupal;
                sPanel.Children.Add(t);
                //קביעת מקום לסתק פאנל והוספתו לגריד
                string h = item.hour_treatment;
                int hour =Convert.ToInt32(h.Substring(0,h.IndexOf(':')));
                int minutes = Convert.ToInt32(h.Substring( h.IndexOf(':')+1));
                Grid.SetRow(sPanel, (hour - 8) * 4 + minutes / 15);
                Grid.SetColumn(sPanel, 1);
                Grid.SetRowSpan(sPanel, item.code_series.num_minutes / 15);
                g1.Children.Add(sPanel);
            }
            
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page1));
        }
    }
}
