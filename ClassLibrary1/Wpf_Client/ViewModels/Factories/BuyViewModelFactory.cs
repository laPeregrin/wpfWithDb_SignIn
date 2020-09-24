using Domain.Services;
using Domain.Services.TransactionServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf_Client.ViewModels.Factories
{
    class BuyViewModelFactory : ISimpleTraderViewModeGenericlFactory<BuyViewModel>
    {
        private IStockPriceService stockPriceService;
        private IBuyStockService buyStockService;

        public BuyViewModelFactory(IStockPriceService stockPriceService, IBuyStockService buyStockService)
        {
            this.stockPriceService = stockPriceService;
            this.buyStockService = buyStockService;
        }

        public BuyViewModel CreateViewModel()
        {
            return new BuyViewModel(stockPriceService, buyStockService);
        }
    }
}
