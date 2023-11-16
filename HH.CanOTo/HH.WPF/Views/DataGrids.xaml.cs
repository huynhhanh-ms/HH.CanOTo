﻿using HH.WPF.ViewModels;
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
    }
}
