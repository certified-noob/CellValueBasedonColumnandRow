using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
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

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGridView.DataContext = loadData();
        }
        int colIndex, rowIndex;
       DataTable loadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Power");
            dt.Columns.Add("Address");
            dt.Rows.Add(new object[] { "Tony Stark, Iron Man", 1000, "Stark Tower" });
            dt.Rows.Add(new object[] { "Steve Rogers, Captain America", 900, "Sheild HQ" });
            dt.Rows.Add(new object[] { "Bucky, Winter Soldier", 800, "Hydra HQ" });
            dt.Rows.Add(new object[] { "Natasha, Black Widow", 700, "Sheild HQ",});
            return dt;
        }
    

        private void GetRowandColumnIndex(object sender, RoutedEventArgs e)
        {
            DataGridCell x = (DataGridCell)sender;
            colIndex = x.Column.DisplayIndex;
            rowIndex = DataGridRow.GetRowContainingElement(x).GetIndex();
            txtColumn.Text = colIndex.ToString();
            txtRow.Text = rowIndex.ToString();
        }

        string RequiredMethod()
        {
            colIndex = Convert.ToInt32(txtColumn.Text);
            rowIndex = Convert.ToInt32(txtRow.Text);
            var dt = ConverttoTable();
            return dt.Rows[rowIndex][colIndex].ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            MessageBox.Show(RequiredMethod());
        }

         public  DataTable ConverttoTable()
        {
            DataView view = (DataView)dataGridView.ItemsSource;
            DataTable dataTable = view.Table.Clone();
            foreach(DataRowView v in view)
            {
                dataTable.Rows.Add(v.Row.ItemArray);
            }
            return dataTable;
        }
    }
}
