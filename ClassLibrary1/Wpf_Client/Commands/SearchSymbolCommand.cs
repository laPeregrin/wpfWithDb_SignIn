using Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Wpf_Client.ViewModels;

namespace Wpf_Client.Commands
{
    class SearchSymbolCommand : ICommand
    {

        public event EventHandler CanExecuteChanged;
        private IStockPriceService _stockPriceService;
        private BuyViewModel _buyViewModel;

        public SearchSymbolCommand(IStockPriceService stockPriceService, BuyViewModel buyViewModel)
        {
            _stockPriceService = stockPriceService;
            _buyViewModel = buyViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return AlwaysTrue;
        }

        public async void Execute(object parameter)
        {
            try
            {
                double stockPrice = await _stockPriceService.GetPrice(_buyViewModel.Symbol);
                _buyViewModel.StockPrice = stockPrice;
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e.Message}............{e.ToString()}");
            }
           
        }


        private bool AlwaysTrue { get; set; } = true;
    }
}
