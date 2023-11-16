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
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown(); // Terminate the application
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
            UpdateUI(SerialPortReader.String2Num(serialPort.ReadExisting()));
        }

        private void UpdateUI(string data)
        {
            // Use a Dispatcher to update the UI from a different thread (since DataReceived event runs on a separate thread)
            Dispatcher.Invoke(() =>
            {
                PortComView.Text = data;
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            serialPort.Close();
        }
        #endregion

    }
}
