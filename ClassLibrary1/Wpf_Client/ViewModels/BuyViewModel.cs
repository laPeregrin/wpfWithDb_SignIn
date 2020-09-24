using Domain.Services;
using Domain.Services.TransactionServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Wpf_Client.Commands;

namespace Wpf_Client.ViewModels
{
    class BuyViewModel : ViewModelBase
    {
        public BuyViewModel(IStockPriceService stockPriceService, IBuyStockService buyStockService)
        {
            SearchSymbolCommand = new SearchSymbolCommand(stockPriceService, this);
            BuyStockCommand = new BuyStockCommand(this, buyStockService);
        }


        private string _symbol;
        public string Symbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
                OnPropertyChanged();
            }
        }
        private double _stockPrice;
        public double StockPrice
        {
            get
            {
                return _stockPrice;
            }
            set
            {
                _stockPrice = value;
                OnPropertyChanged();
            }
        }
        private int _sharesToBuy;
        public int SharesToBuy
        {
            get
            {
                return _sharesToBuy;
            }
            set
            {
                _sharesToBuy = value;
                OnPropertyChanged(nameof(SharesToBuy));
                OnPropertyChanged(nameof(TotalPrice));
            }
        }
        public double TotalPrice
        {
            get { return StockPrice * SharesToBuy; }

        }

        public ICommand SearchSymbolCommand { get; set; }
        public ICommand BuyStockCommand { get; set; }

    }
}
