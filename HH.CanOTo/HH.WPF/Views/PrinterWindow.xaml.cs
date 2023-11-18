using HH.WPF.ViewModels;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
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
using System.Windows.Xps.Packaging;


namespace HH.WPF.Views
{
    /// <summary>
    /// Interaction logic for PrinterWindow.xaml
    /// </summary>
    public partial class PrinterWindow : Window
    {
        public PrinterWindow()
        {
            InitializeComponent();
            InitializePrinter();
        }

        private void InitializePrinter()
        {
            try
            {
                string reportPath = @"Resources/PhieuCan.rdlc";
                reportViewer.LocalReport.ReportPath = reportPath;

                // reportViewer.LocalReport.DataSources.Add(...); 

                ShipmentModel printData = new ShipmentModel() { 
                    
                };
                ReportParameter[] parameters = new ReportParameter[]
                {
                    new ReportParameter("Id", printData.Id.ToString() ?? ""),
                    new ReportParameter("TenKhachHang", printData.TenKhachHang ?? ""),
                    new ReportParameter("DiaChi", printData.DiaChi ?? ""),
                    new ReportParameter("LoaiHangHoa", printData.LoaiHangHoa ?? ""),
                    new ReportParameter("BienSoXe", printData.BienSoXe?.ToString() ?? ""),
                    new ReportParameter("TlXeHang", printData.TlXeHang.ToString()),
                    new ReportParameter("TlXe", printData.TlXe.ToString()),
                    new ReportParameter("TlHang", printData.TlHang.ToString()),
                    //new ReportParameter("GiaMua", printData.GiaMua?.ToString() ?? ""),
                    //new ReportParameter("ThanhTien", printData.ThanhTien?.ToString() ?? ""),
                    new ReportParameter("NgayCan", printData.NgayCan ?.ToString("MM/dd/yyyy") ?? ""),
                    new ReportParameter("GioCanXe", printData.GioCanXe?.ToString("HH:mm") ?? ""),
                    new ReportParameter("GioCanXac", printData.GioCanXac ?.ToString("HH:mm") ?? ""),
                    new ReportParameter("GhiChu", printData.GhiChu?.ToString() ?? "")
                };
                reportViewer.LocalReport.SetParameters(parameters);


                reportViewer.SetPageSettings(new PageSettings
                {
                    //papersize of A4
                    PaperSize = new PaperSize("A4", 827, 1169),
                    PrinterResolution = new PrinterResolution
                    {
                        X = 300,
                        Y = 300,
                        Kind = PrinterResolutionKind.Custom
                    },
                    // Adjust margins (in hundredths of an inch)
                    Margins = new System.Drawing.Printing.Margins(0, 0, 0, 0) // Left, Right, Top, Bottom

                });
                reportViewer.ZoomMode = ZoomMode.PageWidth;
                // Hiển thị báo cáo trong ReportViewer
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                // Tạo một Visual để chứa phần giao diện bạn muốn in
                // Ví dụ: Grid có tên là "printContentGrid" là phần bạn muốn in
                Grid printContentGrid = new Grid();
                // Đưa toàn bộ nội dung giao diện cần in vào printContentGrid

                // Tạo một DrawingVisual
                DrawingVisual visual = new DrawingVisual();

                // Sử dụng DrawingContext để vẽ nội dung của printContentGrid
                using (DrawingContext context = visual.RenderOpen())
                {
                    VisualBrush brush = new VisualBrush(printContentGrid);
                    context.DrawRectangle(brush, null, new Rect(new Point(), printContentGrid.RenderSize));
                }

                // In nội dung được tạo ra
                printDialog.PrintVisual(visual, "Print Description");
            }
        }
    }
}
