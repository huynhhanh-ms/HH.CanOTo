using ShowMeTheXAML;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HH.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            this.Exit += Window_Closed;

            XamlDisplay.Init();
            base.OnStartup(e);
        }

        private void Window_Closed(object sender, ExitEventArgs e)
        {
            Application.Current.Shutdown(); // Terminate the application
        }
    }
}
