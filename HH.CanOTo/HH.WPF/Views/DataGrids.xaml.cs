using HH.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
        public ShipmentListViewModel data;
        public DataGrids()
        {
            data = new ShipmentListViewModel();
            DataContext = data;
            InitializeComponent();
        }

        public void datagrids_LostFocus(object sender, RoutedEventArgs e)
        {
            DataGridCell cell = sender as DataGridCell;
            if (cell != null)
            {
                var editedValue = (cell.Content as TextBlock).Text;
            }
        }


        private void gridview1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            //MessageBox.Show("CellEditEnding"); 
        }

        private void myDataGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DependencyObject dep = (DependencyObject)e.OriginalSource;

            // Tìm DataGridRow từ sự kiện Click
            while (!(dep is DataGridRow) && dep != null)
            {
                dep = VisualTreeHelper.GetParent(dep);
            }

            if (dep is DataGridRow row)
            {
                // Chọn dòng được click
                row.IsSelected = true;
            }
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta / 7);
            e.Handled = true;
        }


        #region Keyboard Move
        private void gridview1_KeyUp(object sender, KeyEventArgs e)
        {
            //key event  
            DataGrid dg = sender as DataGrid;
            DataGridCellInfo cellinfo = dg.CurrentCell;
            DataGridCell cell = TryToFindGridCell(dg, cellinfo);
            var columnIndex = dg.Columns.IndexOf(dg.CurrentColumn);
            var rowIndex = dg.Items.IndexOf(dg.CurrentItem);

            if (cell.IsEditing == true && e.Key == Key.Right)
            {
                //cancel edit, save current text, move cell  
                cell.Content = "dummy";         //when press arrow, "dummy" deleted and current text is saved  
                this.gridview1.CancelEdit();
                try
                {
                    this.gridview1.CurrentCell = new DataGridCellInfo(gridview1.Items[rowIndex], gridview1.Columns[columnIndex + 1]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    //last column exception  
                    this.gridview1.CurrentCell = new DataGridCellInfo(gridview1.Items[rowIndex], gridview1.Columns[columnIndex]);
                }
            }
            else if (cell.IsEditing == true && e.Key == Key.Left)
            {
                //cancel edit, save current text, move cell  
                cell.Content = "dummy";
                this.gridview1.CancelEdit();
                try
                {
                    this.gridview1.CurrentCell = new DataGridCellInfo(gridview1.Items[rowIndex], gridview1.Columns[columnIndex - 1]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    //first column exception  
                    this.gridview1.CurrentCell = new DataGridCellInfo(gridview1.Items[rowIndex], gridview1.Columns[columnIndex]);
                }
            }
            else if (cell.IsEditing == true && e.Key == Key.Up)
            {
                //cancel edit, save current text, move cell  
                cell.Content = "dummy";
                this.gridview1.CancelEdit();
                try
                {
                    this.gridview1.CurrentCell = new DataGridCellInfo(gridview1.Items[rowIndex - 1], gridview1.Columns[columnIndex]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    //first row exception  
                    this.gridview1.CurrentCell = new DataGridCellInfo(gridview1.Items[rowIndex], gridview1.Columns[columnIndex]);
                }
            }
            else if (cell.IsEditing == true && e.Key == Key.Down)
            {
                //cancel edit, save current text, move cell  
                cell.Content = "dummy";
                this.gridview1.CancelEdit();
                try
                {
                    this.gridview1.CurrentCell = new DataGridCellInfo(gridview1.Items[rowIndex + 1], gridview1.Columns[columnIndex]);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    //last row exception  
                    this.gridview1.CurrentCell = new DataGridCellInfo(gridview1.Items[rowIndex], gridview1.Columns[columnIndex]);
                }
            }

        }

        static DataGridCell TryToFindGridCell(DataGrid grid, DataGridCellInfo cellInfo)
        {
            DataGridCell result = null;
            DataGridRow row = (DataGridRow)grid.ItemContainerGenerator.ContainerFromItem(cellInfo.Item);
            if (row != null)
            {
                int columnIndex = grid.Columns.IndexOf(cellInfo.Column);
                if (columnIndex > -1)
                {
                    DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(row);
                    result = presenter.ItemContainerGenerator.ContainerFromIndex(columnIndex) as DataGridCell;
                }
            }
            return result;
        }

        static T GetVisualChild<T>(Visual parent) where T : Visual
        {
            T child = default(T);
            int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < numVisuals; i++)
            {
                Visual v = (Visual)VisualTreeHelper.GetChild(parent, i);
                child = v as T;
                if (child == null)
                {
                    child = GetVisualChild<T>(v);
                }
                if (child != null)
                {
                    break;
                }
            }
            return child;
        }
        #endregion

        private void gridview1_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()).ToString();

        }
    }
}
