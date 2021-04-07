using System;
using System.Collections.Generic;
using System.Data;
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


        DataGridCell RequiredMethod()
        {
            return new DataGridCell();
        }
    }
}
