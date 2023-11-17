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
using System.IO.Ports;
using HH.WPF.Util;
using HH.WPF.Views;

namespace HH.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SerialPort serialPort;
        
        public MainWindow()
        {

            InitializeComponent();
            InitializeSerialPort();

            DataGrids.gridview1.SelectedCellsChanged += MyDataGrid_SelectedCellsChanged;
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown(); // Terminate the application
        }

        private void MyDataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            // Get the positions of selected cells
            StringBuilder positions = new StringBuilder();

            foreach (DataGridCellInfo cellInfo in DataGrids.gridview1.SelectedCells)
            {
                int columnIndex = cellInfo.Column.DisplayIndex; // Index of the column
                int rowIndex = DataGrids.gridview1.Items.IndexOf(cellInfo.Item); // Index of the row

                positions.Append($"Column: {columnIndex + 1}, Row: {rowIndex + 1}\n");
            }

            // Display positions in the TextBox
            positionTextBox.Text = positions.ToString();
        }




        //  ┏┓    •  ┓  ┏┓       ┓┏     ┓┓•    
        //  ┗┓┏┓┏┓┓┏┓┃  ┃┃┏┓┏┓╋  ┣┫┏┓┏┓┏┫┃┓┏┓┏┓
        //  ┗┛┗ ┛ ┗┗┻┗  ┣┛┗┛┛ ┗  ┛┗┗┻┛┗┗┻┗┗┛┗┗┫
        //                                    ┛
        #region Serial Port Handling
        private void InitializeSerialPort()
        {
            serialPort = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

            try
            {
                serialPort.Open();
                serialPort.DataReceived += SerialPort_DataReceived;
                // Display COM port information
                //string portInfo = $"COM Port: {serialPort.PortName}\n";
                //portInfo += $"Baud Rate: {serialPort.BaudRate}\n";
                //portInfo += $"Data Bits: {serialPort.DataBits}\n";
                //portInfo += $"Parity: {serialPort.Parity}\n";
                //portInfo += $"Stop Bits: {serialPort.StopBits}\n";
                //portInfo += $"Handshake: {serialPort.Handshake}";
                //portInfoText.Text = portInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối với Thiết Bị Cân\nError:" + ex.Message);
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            UpdateUI((serialPort.ReadExisting()));
        }

        private void UpdateUI(string data)
        {
            // Use a Dispatcher to update the UI from a different thread (since DataReceived event runs on a separate thread)
            Dispatcher.Invoke(() =>
            {
                PortComView.Text = SerialPortReader.String2Num(data);
                PortComViewRaw.Text = "Com Raw : " + data;
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            serialPort.Close();
        }
        #endregion

        private void ButtonThemMoi_Click(object sender, RoutedEventArgs e)
        {
            DataGrids.data.AddItem();
            ScrollToEnd();
        }



        private void ScrollToEnd()
        {
            ScrollViewer scrollViewer = GetScrollViewer(DataGrids);
            if (scrollViewer != null)
            {
                //scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + 50); 
                scrollViewer.ScrollToEnd();
            }
        }
        private ScrollViewer GetScrollViewer(DependencyObject control)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(control); i++)
            {
                DependencyObject child = VisualTreeHelper.GetChild(control, i);
                if (child is ScrollViewer)
                {
                    return (ScrollViewer)child;
                }
                else
                {
                    ScrollViewer result = GetScrollViewer(child);
                    if (result != null)
                        return result;
                }
            }
            return null;
        }
        private void ButtonCanXe_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrids.gridview1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa chọn hàng cần cân");
                return;
            }
            DataGridCellInfo selectedCell = DataGrids.gridview1.SelectedCells[0];

            foreach(var item in DataGrids.data.ShipmentList)
            {
                if (item.IsSelected)
                {
                    Console.WriteLine();
                }
            }

            int rowIndex = DataGrids.gridview1.Items.IndexOf(selectedCell.Item);
            int columnIndex = selectedCell.Column.DisplayIndex;

            var selectedItem = DataGrids.gridview1.Items[rowIndex];

            String newValue = PortComView.Text;
            DataGrids.data.UpdateTlXeOfItem(rowIndex, int.Parse(newValue));
            //DataGrids.gridview1.Items.Refresh();
        }

        private void ButtonCanXeHang_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrids.gridview1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Chưa chọn hàng cần cân");
                return;
            }
            DataGridCellInfo selectedCell = DataGrids.gridview1.SelectedCells[0];

            foreach(var item in DataGrids.data.ShipmentList)
            {
                if (item.IsSelected)
                {
                    Console.WriteLine();
                }
            }

            int rowIndex = DataGrids.gridview1.Items.IndexOf(selectedCell.Item);
            int columnIndex = selectedCell.Column.DisplayIndex;

            var selectedItem = DataGrids.gridview1.Items[rowIndex];

            String newValue = PortComView.Text;
            DataGrids.data.UpdateTlXeHangOfItem(rowIndex, int.Parse(newValue));
            //DataGrids.gridview1.Items.Refresh();
        }

        private void ButtonInPhieuCan_Click(object sender, RoutedEventArgs e)
        {
            //open Printer window
            PrinterWindow printerWindow = new PrinterWindow();
            printerWindow.Owner = this;
            printerWindow.ShowDialog();
        }
    }
}
