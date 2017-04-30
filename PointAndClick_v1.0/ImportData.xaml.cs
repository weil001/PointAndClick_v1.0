using System;
using System.Windows;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Input;
using System.Windows.Media;

namespace PointAndClick_v1._0
{
    /// <summary>
    /// Interaction logic for ImportData.xaml
    /// </summary>
    public partial class ImportData : Page
    {
        public ImportData()
        {
            InitializeComponent();
            fillPostalMate();
        }

        private void fillPostalMate()
        {

            string connectionString = "User=SYSDBA; Password=3k7rur9e; Database=PCS; DataSource=localhost; Port=3050;";

            using (FbConnection con = new FbConnection(connectionString))
            {
                var Query = "SELECT rdb$field_name AS PRODUCT FROM rdb$relation_fields WHERE rdb$relation_name = 'PRODUCT'";
                var dataAdapter = new FbDataAdapter(Query, con);
                var commandBuilder = new FbCommandBuilder(dataAdapter);
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGrid1.ItemsSource = dt.DefaultView;
            }

        }

        // Reads in a .csv file and stores contents in a datatable
        //SELECT * FROM [{0}]
        private DataTable ReadCSV(string fileName)
        {
            DataTable dt = new DataTable("Data");
            using (OleDbConnection cn = new System.Data.OleDb.OleDbConnection("Provider=MIcrosoft.Jet.OLEDB.4.0;Data Source=\"" + Path.GetDirectoryName(fileName) + "\"; Extended Properties='text;HDR=yes;FMT=Delimeted(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("SELECT * FROM [{0}]", new FileInfo(fileName).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            // Creates and displays a new data table with only the CSV headers
            DataTable dt2 = new DataTable("CSV Headers");
            dt2.Columns.Add("CSV Headers", typeof(string));

            foreach (DataColumn column in dt.Columns)
            {
                dt2.Rows.Add(column.ColumnName);
            }      

            return dt2;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure you want to cancel this operation?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                App.Current.Shutdown();
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Browse button opens a file explorer and allows user to select a .csv file
        private void browseCSV_Click(object sender, RoutedEventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    dataGrid2.ItemsSource = ReadCSV(ofd.FileName).DefaultView;

                    System.Windows.MessageBox.Show("Change CSV Dialogue Prompt", "Confirm", MessageBoxButton.OK, MessageBoxImage.Question);
                }
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("Welcome.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void refreshButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
