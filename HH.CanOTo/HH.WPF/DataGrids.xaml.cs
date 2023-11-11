using HH.WPF.Domain;
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
using System.Windows.Shapes;

namespace HH.WPF
{
    /// <summary>
    /// Interaction logic for DataGrids.xaml
    /// </summary>
    public partial class DataGrids
    {
        public DataGrids()
        {
            DataContext = new ListsAndGridsViewModel();
            InitializeComponent();
        }

        public void datagrids_LostFocus(object sender, RoutedEventArgs e)
        {
            DataGridCell cell = sender as DataGridCell;
            if (cell != null)
            {
                // Get the new value from the cell and update the data source
                var editedValue = (cell.Content as TextBlock).Text;
                // Use the data to update your data source, e.g., ObservableCollection
                // myDataGrid.ItemsSource is the data source of the DataGrid
                // Perform the data update here
            }
        }


        private void gridview1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //MessageBox.Show("CellEditEnding"); 
        }
    }
}
