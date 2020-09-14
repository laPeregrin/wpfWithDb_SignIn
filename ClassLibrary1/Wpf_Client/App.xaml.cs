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
            //new MajorIndexService().GetMajorIndex(Domain.Models.MajorIndexType.DownJones).ContinueWith((task) =>
            //{
            //    var index = task.Result;
                
            //}); simple test how to work API via GetMajorIndex and with this task continue to task => index = task.Result()


            Window window = new MainWindow();
            window.DataContext = new MainViewModel();

            base.OnStartup(e);
        }
    }
}
