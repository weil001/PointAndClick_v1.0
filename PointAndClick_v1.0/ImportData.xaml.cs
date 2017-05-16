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
using System.Linq;

namespace PointAndClick_v1._0
{
    /// <summary>
    /// Interaction logic for ImportData.xaml
    /// </summary>
    public partial class ImportData : Page
    {
        public static DataTable dt = new DataTable("dtTable");
        public static DataTable dt1 = new DataTable("dt1Table");
        public static DataTable dt3 = new DataTable("dt3Table");
        public static DataTable dtMapped = new DataTable("dtMappedTable");
        public static string csvFilepath = string.Empty;
        
        public ImportData()
        {
            InitializeComponent();
            fillPostalMate();
        }

        //DataTable dt3;
        //DataTable dtMapped = new DataTable();

        //Checks if PRODUCTID, DEPARTMENTREF, TAXCATEGORYREF, VENDORREF, GLYPHREF is in CSV datatable
        //If not adds them to datatable
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

        //Compares headers from csv and Product datatables
        //Returns mapped or partially mapped in header datatable
        private DataTable mapping(DataTable dt1, DataTable dt2)
        {
            string dt1Row;
            string dt2Row;
            string mapped;
            foreach (DataRow row in dt1.Rows)
            {
                //Gets Column name from dt1
                dt1Row = row["CSV Headers"].ToString();
                foreach (DataRow row2 in dt2.Rows)
                {
                    //Gets Column name from dt2 and makes it lower case and without spaces
                    dt2Row = row2["PRODUCT"].ToString();
                    while (dt2Row.IndexOf("  ") >= 0)
                        dt2Row = dt2Row.Replace(" ", "");
                    dt1Row = dt1Row.ToLower();
                    dt2Row = dt2Row.ToLower();
                    dt1Row = dt1Row.Substring(0, 3);
                    dt2Row = dt2Row.Substring(0, 3);
                    mapped = row["Mapped"].ToString();
                    if (dt2Row == dt1Row && mapped != "Mapped")
                    {
                        row["Mapped"] = "Partial";
                    }
                    dt1Row = row["CSV Headers"].ToString();
                    dt2Row = row2["PRODUCT"].ToString();
                    while (dt2Row.IndexOf("  ") >= 0)
                        dt2Row = dt2Row.Replace(" ", "");

                    if (dt2Row == dt1Row)
                    {
                        row["Mapped"] = "Mapped";
                    }

                }
            }
            return dt1;
        }

        //Creates a datatable with only the mapped csv headers
        private DataTable dtToInsert(DataTable dt1, DataTable dt2)
        {
            string mapped;
            string columnName;
            dtMapped = dt1;
            foreach (DataRow row in dt2.Rows)
            {
                mapped = row["Mapped"].ToString();
                if (mapped != "Mapped")
                {
                    columnName = row["CSV Headers"].ToString();
                    foreach (DataColumn column in dt1.Columns)
                    {
                        if (columnName == column.ColumnName.ToString())
                        {
                            dtMapped.Columns.Remove(column);
                            break;
                        }

                    }
                }

            }

            return dtMapped;
        }

        //Creates SQL command from Mapped Data Table
        string createfbCommand(DataTable dtMapped)
        {
            string fbCommand = "INSERT INTO PRODUCT(";
            foreach (DataColumn column in dtMapped.Columns)
            {
                fbCommand = fbCommand + column.ColumnName.ToString() + ",";
            }
            fbCommand = fbCommand.Substring(0, fbCommand.LastIndexOf(","));
            fbCommand = fbCommand + ") VALUES (";
            foreach (DataColumn column in dtMapped.Columns)
            {
                fbCommand = fbCommand + "@" + column.ColumnName.ToString() + ",";
            }

            fbCommand = fbCommand.Substring(0, fbCommand.LastIndexOf(","));
            fbCommand = fbCommand + ");";
            return fbCommand;
        }

        private void fillPostalMate()
        {
            DataTable dt5 = new DataTable("SQL");
            string connectionString = "User=SYSDBA; Password=3k7rur9e; Database=PCS; DataSource=localhost; Port=3050;";

            using (FbConnection con = new FbConnection(connectionString))
            {
                var Query = "SELECT rdb$field_name AS PRODUCT FROM rdb$relation_fields WHERE rdb$relation_name = 'PRODUCT'";
                var dataAdapter = new FbDataAdapter(Query, con);
                var commandBuilder = new FbCommandBuilder(dataAdapter);
                dataAdapter.Fill(dt5);
                dataGrid1.ItemsSource = dt5.DefaultView;
                dt3 = dt5;
            }

        }

        // Reads in a .csv file and stores contents in a datatable
        private DataTable ReadCSV(string fileName)
        {
            //dt = new DataTable("Data");
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
            csvFilepath = fileName;
            dt = checkInitialColumns(dt);


            // Creates and displays a new data table with only the CSV headers
            DataTable dt2 = new DataTable("CSV Headers");
            dt2.Columns.Add("CSV Headers", typeof(string));

            foreach (DataColumn column in dt.Columns)
            {
                dt2.Rows.Add(column.ColumnName);
            }
            dt2.Columns.Add("Mapped");
            dt2.Rows.Add("LABOR");
            dt2.Rows.Add("DIM");
            dt2 = mapping(dt2, dt3);
            dtMapped = dtToInsert(dt, dt2);
            return dt2;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure you want to cancel this operation?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                App.Current.Shutdown();
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

                    System.Windows.MessageBox.Show(csvFilepath, "Confirm", MessageBoxButton.OK, MessageBoxImage.Question);
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
        
        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            int rowCount = dtMapped.Rows.Count;
            string connectionString = "User=SYSDBA; Password=3k7rur9e; Database=PCS; DataSource=localhost; Port=3050;";

            try
            {
                using (FbConnection conn = new FbConnection(connectionString))
                {
                    conn.Open();


                    string insertFbCommand = createfbCommand(dtMapped);
                    string columnName;
                    string atColumnName;
                    int productID;

                    //Go through each row of Mapped Datatable
                    for (int i = 0; i < rowCount; i++)
                    {
                        FbCommand cmd = new FbCommand(insertFbCommand, conn);

                        foreach (DataColumn column in dtMapped.Columns)
                        {
                            //Gets Name of each column of row
                            columnName = column.ColumnName.ToString();
                            atColumnName = "@" + columnName;
                            //If  productID turns object into Int and adds value to sql command
                            if (columnName == "PRODUCTID")
                            {
                                productID = Convert.ToInt32(dtMapped.Rows[i][columnName]);
                                cmd.Parameters.AddWithValue(atColumnName, productID);
                            }
                            //If one of main header columns and empty,  adds 0 as value to sql command
                            else if (dtMapped.Rows[i][columnName].ToString() == "")
                            {
                                if (columnName == "DEPARTMENTREF" || columnName == "TAXCATEGORYREF" || columnName == "VENDORREF" || columnName == "GLYPHREF")
                                {
                                    cmd.Parameters.AddWithValue(atColumnName, 0);
                                }
                            }
                            //If NULL value, returns value as null at that column
                            else if (dtMapped.Rows[i][columnName].ToString() == "NULL" || dtMapped.Rows[i][columnName].ToString() == "null" || dtMapped.Rows[i][columnName].ToString() == "Null")
                            {
                                cmd.Parameters.AddWithValue(atColumnName, DBNull.Value);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(atColumnName, dtMapped.Rows[i][columnName]);
                            }
                        }

                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch
            {

            }



            System.Windows.MessageBox.Show("Import Complete");
        }

        private void editbutton_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("EditCSV.xaml", UriKind.Relative);
            this.NavigationService.Navigate(uri);
        }
    }
}
