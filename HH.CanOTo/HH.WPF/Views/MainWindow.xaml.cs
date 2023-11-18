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

using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Windows.Interop;
using System.Threading;
using System.ComponentModel;

namespace HH.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SerialPort serialPort;

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        public MainWindow()
        {

            InitializeComponent();
            InitializeSerialPort();
            InitializeCamera();

            Closing += Window_Closed;
            DataGrids.gridview1.SelectedCellsChanged += MyDataGrid_SelectedCellsChanged;
        }

        #region Camera Handling
        private void InitializeCamera()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //BitmapSource bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(
            //    ((Bitmap)eventArgs.Frame.Clone()).GetHbitmap(),
            //    IntPtr.Zero,
            //    Int32Rect.Empty,
            //    BitmapSizeOptions.FromEmptyOptions());

            //imgCamera.Source = bitmapSource;

            imageCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        #endregion


        private void Window_Closed(object sender, CancelEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
            MessageBoxResult result = MessageBox.Show("Bạn Chắc Muốn Thoát Chứ", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
                return;
            }
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

            foreach (var item in DataGrids.data.ShipmentList)
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

            foreach (var item in DataGrids.data.ShipmentList)
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

        #region
        //To end or cancel all tasks in a WPF application,
        //you can maintain a collection of tasks and cancel or wait for them to complete as needed.
        //When the application is shutting down or you want to stop all tasks,
        //you can loop through this collection and cancel or await the tasks.
        private List<Task> runningTasks = new List<Task>();

        //public MainWindow()
        //{
        //    InitializeComponent();
        //}

        // Method to start a new task
        private async void StartNewTask()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(async () =>
            {
                // Simulated long-running task
                await Task.Delay(5000, token); // Replace this with your actual task logic
            }, token);

            runningTasks.Add(task);

            try
            {
                await task;
            }
            catch (OperationCanceledException ex)
            {
                // Handle cancellation if needed
                Console.WriteLine("Task was canceled: " + ex.Message);
            }
            finally
            {
                runningTasks.Remove(task);
                cancellationTokenSource.Dispose();
            }
        }

        // Method to cancel all running tasks
        private async void CancelAllTasks()
        {
            foreach (var task in runningTasks)
            {
                if (task.Status == TaskStatus.Running || task.Status == TaskStatus.WaitingToRun)
                {
                    try
                    {
                        // Cancel the task
                        var taskCancellationSource = Task.FromCanceled(new CancellationToken(true));
                        await taskCancellationSource;
                    }
                    catch (OperationCanceledException)
                    {
                        // Task was canceled
                    }
                }
            }

            runningTasks.Clear();
        }

        // Event handler to start a task
        private void StartTaskButton_Click(object sender, RoutedEventArgs e)
        {
            StartNewTask();
        }

        // Event handler to cancel all tasks
        private void CancelTasksButton_Click(object sender, RoutedEventArgs e)
        {
            CancelAllTasks();
        }
        #endregion
    }





}
