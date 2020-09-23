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
using Microsoft.Extensions.DependencyInjection;
using Wpf_Client.States.Navigation;
using Wpf_Client.ViewModels.Factories;

namespace Wpf_Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override  void OnStartup(StartupEventArgs e)
        {
            IServiceProvider serviceProvider = CreateServiceProvider();

            Window window = serviceProvider.GetRequiredService<MainWindow>();


            base.OnStartup(e);
        }
        private IServiceProvider CreateServiceProvider()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<DbContextOptionsFactory>();
            services.AddSingleton<IDataService<Account>, AccountDataService>();
            services.AddSingleton<IStockPriceService, StockPriceService>();
            services.AddSingleton<IBuyStockService, BuyStockService>();
            services.AddSingleton<IMajorIndexService, MajorIndexService>();

            services.AddSingleton<ISimpleTraderViewModelAbstractFactory, SimpleTraderViewModelAbstractFactory>();
            services.AddSingleton<ISimpleTraderViewModeGenericlFactory<HomeViewModel>, HomerViewModelFactory>();
            services.AddSingleton<ISimpleTraderViewModeGenericlFactory<PortfolioViewModel>, PortfolioViewModelFactory>();
            services.AddSingleton<ISimpleTraderViewModeGenericlFactory<MajorIndexListingViewModel>, MajorIndexListeningViewModelFactory>();

            services.AddScoped<INavigator, Navigator>();
            services.AddSingleton<MainViewModel>();

            services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<MainViewModel>()));

            return services.BuildServiceProvider();
        }
    }

}
