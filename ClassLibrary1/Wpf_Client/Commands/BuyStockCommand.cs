using Domain.Models;
using Domain.Services;
using Domain.Services.TransactionServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Wpf_Client.ViewModels;

namespace Wpf_Client.Commands
{
    class BuyStockCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private BuyViewModel _buyViewModel;
        private IBuyStockService _buyStockService;

        public BuyStockCommand(BuyViewModel buyViewModel, IBuyStockService buyStockService)
        {
            _buyViewModel = buyViewModel;
            _buyStockService = buyStockService;
        }

        public bool CanExecute(object parameter)
        {
            return AlwaysTrue;
        }

        public async void Execute(object parameter)
        {
            try
            {
                await _buyStockService.BuyStock(new Domain.Models.Account
                {
                    id=12,
                    Balance=700,
                    AssetTransactions = new List<AssetTransaction>(),

                },_buyViewModel.Symbol,_buyViewModel.SharesToBuy);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public bool AlwaysTrue { get; private set; } = true;
    }
}
