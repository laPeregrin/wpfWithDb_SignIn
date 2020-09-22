using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Wpf_Client.ViewModels;
using FinancialModelin.Services;
using Domain.Services.TransactionServices;
using Domain.Services;
using ClassLibrary1.Services;
using TraderEntityFrameWork.Services;
using Domain.Models;
using TraderEntityFrameWork;
using FinancialModelin;

namespace Wpf_Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public  partial class App : Application
    {
        protected  override async void OnStartup(StartupEventArgs e)
        {
            //FinancialModelingPrepHttpClientFactory _httpFactory = new FinancialModelingPrepHttpClientFactory();
            //IDataService<Account> accountService = new AccountDataService(new DbContextOptionsFactory());
            //IStockPriceService stockPriceService = new StockPriceService(_httpFactory);
            //IBuyStockService buyStockService = new BuyStockService(stockPriceService, accountService);

            //Account buyer = await accountService.Get(12);
            //await buyStockService.BuyStock(buyer, "T", 1);


            Window window = new MainWindow();
            window.DataContext = new MainViewModel();


            base.OnStartup(e);
        }
    }
}
