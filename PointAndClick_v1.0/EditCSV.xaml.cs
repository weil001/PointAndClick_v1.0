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
    /// Interaction logic for EditCSV.xaml
    /// </summary>
    public partial class EditCSV : Page
    {
        string myFile;
       // csvFilepath = fileName;

        public EditCSV()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure you want to cancel this operation?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                App.Current.Shutdown();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("ImportData.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            /*
            // overwrites csv file with appended primary / foreign key columns from products table
            csvDataGrid.SelectAllCells();
            csvDataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, csvDataGrid);
            csvDataGrid.UnselectAllCells();
            string result = (string)System.Windows.Clipboard.GetData(System.Windows.DataFormats.CommaSeparatedValue);
            File.WriteAllText(csvFilepath, result);
            */
        }

        private void csvDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
