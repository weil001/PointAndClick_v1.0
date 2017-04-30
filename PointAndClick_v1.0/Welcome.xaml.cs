using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointAndClick_v1._0
{
    /// <summary>
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Page
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure you want to cancel this operation?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                App.Current.Shutdown();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("ImportData.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked == true)
            {
                nextButton.IsEnabled = true;
            }
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked == true)
            {
                nextButton.IsEnabled = true;
            }
        }

        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true && checkBox2.IsChecked == true && checkBox3.IsChecked == true)
            {
                nextButton.IsEnabled = true;
            }
        }
    }
}
