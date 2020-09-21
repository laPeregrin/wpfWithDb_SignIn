using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Wpf_Client.ViewModels;
using FinancialModelin.Services;

namespace Wpf_Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
           
            Window window = new MainWindow();
            window.DataContext = new MainViewModel();


            base.OnStartup(e);
        }
    }
}
