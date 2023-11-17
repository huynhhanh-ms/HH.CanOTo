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

                // Nạp dữ liệu vào báo cáo (nếu cần)
                // reportViewer.LocalReport.DataSources.Add(...); // Thêm DataSource nếu cần


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
                    Margins = new System.Drawing.Printing.Margins(0,0,0,0) // Left, Right, Top, Bottom
                    
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
