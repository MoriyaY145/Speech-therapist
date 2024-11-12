using speechTherapist.ServiceReference2;
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
    public sealed partial class page6 : Page
    {
        Service1Client client = new Service1Client();

        public page6()
        {
            this.InitializeComponent();
        }

        private void tb6_Click(object sender, RoutedEventArgs e)
        {
            lvProblems.Visibility = Visibility.Visible;
        }

        private void f6_Click(object sender, RoutedEventArgs e)
        {
            TextBox t = new TextBox
            {
                Width = 496,
                FontSize = 22
            };
            sPanel.Children.Add(t);
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(page_2));
        }

        private void AppBarButton_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private async void Page_Loading(FrameworkElement sender, object args)
        {
            lvProblems.ItemsSource =await client.GetProblemsAsync();
        }

        private async void b1_Click(object sender, RoutedEventArgs e)
        {
            metupal m = new metupal();
            m.id_metupal = tb1.Text;
            m.name_metupal = tb2.Text;
            m.date_birth = tb4.Date.Date.ToString("dd/MM/yyyy");
            m.phone_number = tb5.Text;
            m.kupat_cholim = tb7.Text;
            m.communication_date = tb8.Date.Date.ToString("dd/MM/yyyy");
            m.status = tb9.Text;
            m.notes = tb10.Text;
            m.id_metupal = tb2.Text;
            int x = await client.AddMetupalAsync(m);
            if (x > 0)
                txtMassege.Text = "!המטופל נוסף בהצלחה";
            else
                txtMassege.Text = "!הנתונים לא נשמרו - בדוק את תקינות הנתונים";

            //למלא את הפרטים ולשמור
            for (int i = 0; i < lvProblems.Items.Count; i++)
            {
                
                //ליצור עצם של בעיה למטופל ולמלא ולשמור
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if(e.Parameter!=null)
            {
                metupal m = e.Parameter as metupal;
                tb1.Text = m.id_metupal;
                tb2.Text = m.name_metupal;
                tb4.SelectedDate =Convert.ToDateTime(m.date_birth);
                tb5.Text = m.phone_number;
                tb8.SelectedDate =Convert.ToDateTime(m.communication_date);
                tb10.Text = m.notes;
                tb7.SelectedItem = m.kupat_cholim;
                tb9.SelectedItem = m.status;
                var t = client.GetProblemForMetupalByNameMetupalAsync(m.name_metupal);
                lvProblems.SelectedItem = t;
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            this.Opacity = 0.2;
            p1.IsOpen = true;
        }
    }
}
