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
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace PointAndClick_v1._0
{
    /// <summary>
    /// Interaction logic for EditCSV.xaml
    /// </summary>
    public partial class EditCSV : Page
    {

        public EditCSV()
        {
            InitializeComponent();
            //csvDataGrid.ItemsSource = ImportData.dtMapped.DefaultView;


           // /*
            DataTable csvDt = new DataTable("Data");
            using (OleDbConnection cn = new OleDbConnection("Provider=MIcrosoft.Jet.OLEDB.4.0;Data Source=\"" + Path.GetDirectoryName(ImportData.csvFilepath) + "\"; Extended Properties='text;HDR=yes;FMT=Delimeted(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select *from [{0}]", new FileInfo(ImportData.csvFilepath).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(csvDt);
                    }
                }
            }
            csvDt = checkInitialColumns(csvDt);
            csvDataGrid.ItemsSource = csvDt.DefaultView;
            // */
        }

        private DataTable checkInitialColumns(DataTable dt1)
        {
            string columnDT1;
            bool productID = false;
            bool departmentRef = false;
            bool taxCatergoryRef = false;
            bool vendorRef = false;
            bool glyphRef = false;
            foreach (DataColumn column in dt1.Columns)
            {
                columnDT1 = column.ColumnName.ToString();
                if (columnDT1 == "PRODUCTID")
                {
                    productID = true;
                }
                else if (columnDT1 == "DEPARTMENTREF")
                {
                    departmentRef = true;
                }
                else if (columnDT1 == "TAXCATEGORYREF")
                {
                    taxCatergoryRef = true;
                }
                else if (columnDT1 == "VENDORREF")
                {
                    vendorRef = true;
                }
                else if (columnDT1 == "GLYPHREF")
                {
                    glyphRef = true;
                }
            }
            if (!productID)
            {
                dt1.Columns.Add("PRODUCTID");
            }
            if (!departmentRef)
            {
                dt1.Columns.Add("DEPARTMENTREF");
            }
            if (!taxCatergoryRef)
            {
                dt1.Columns.Add("TAXCATEGORYREF");
            }
            if (!vendorRef)
            {
                dt1.Columns.Add("VENDORREF");
            }
            if (!glyphRef)
            {
                dt1.Columns.Add("GLYPHREF");
            }
            //Asks to fill in data for the recently added columns
            if (productID == false || departmentRef == false || taxCatergoryRef == false || vendorRef == false || glyphRef == false)
            {
                /*
                System.Windows.MessageBox.Show("Please fill in information for the following columns then refresh: ");
                if (!productID)
                {
                    System.Windows.MessageBox.Show("PRODUCTID");
                }
                if (!departmentRef)
                {
                    System.Windows.MessageBox.Show("DEPARTMENTREF");
                }
                if (!taxCatergoryRef)
                {
                    System.Windows.MessageBox.Show("TAXCATEGORYREF");
                }
                if (!vendorRef)
                {
                    System.Windows.MessageBox.Show("VENDORREF");
                }
                if (!glyphRef)
                {
                    System.Windows.MessageBox.Show("GLYPHREF");
                }*/
            }
            return dt1;

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

        private void backupButton_Click(object sender, RoutedEventArgs e)
        {
            
            // appends "(Backup)" before .csv file format to create a new file, not overwrite existing
            var fileName = String.Format("{0}({1}){2}",
            Path.GetFileNameWithoutExtension(ImportData.csvFilepath), "Backup", Path.GetExtension(ImportData.csvFilepath));
            ImportData.csvFilepath = Path.Combine(Path.GetDirectoryName(ImportData.csvFilepath), fileName);

            // creates backup csv file of all current data in csvDataGrid
            csvDataGrid.SelectAllCells();
            csvDataGrid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, csvDataGrid);
            csvDataGrid.UnselectAllCells();
            string result = (string)System.Windows.Clipboard.GetData(System.Windows.DataFormats.CommaSeparatedValue);
            File.WriteAllText(ImportData.csvFilepath, result);

            System.Windows.MessageBox.Show("Backup Created! " + "\n" + ImportData.csvFilepath, "Confirm", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void csvDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
