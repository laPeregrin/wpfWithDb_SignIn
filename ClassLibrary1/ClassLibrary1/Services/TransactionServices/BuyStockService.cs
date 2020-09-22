using ClassLibrary1.Services;
using Domain.Exceptions;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.TransactionServices
{
    public class BuyStockService : IBuyStockService
    {
        private readonly IStockPriceService _stockPriceService;
        private readonly IDataService<Account> _accountDataService;

        public BuyStockService(IStockPriceService stockPriceService, IDataService<Account> accountService)
        {
            _stockPriceService = stockPriceService;
            _accountDataService = accountService;
        }

        public async Task<Account> BuyStock(Account buyer, string symbol, int shares)
        {
            double stockPrice = await _stockPriceService.GetPrice(symbol);
            double transactionPrice = stockPrice * shares;

            if(transactionPrice > buyer.Balance)
            {
                throw new InsufficientFundsException(buyer.Balance, transactionPrice);
            }

            AssetTransaction transaction = new AssetTransaction()
            {
                Account = buyer,
                Asset = new Asset()
                {
                    PricePerSharper = stockPrice,
                    Symbol = symbol
                },
                DateProcessed = DateTime.Now,
                Shares = shares,
                IsPurchase = true
            };

            buyer.AssetTransactions.Add(transaction);
            buyer.Balance -= transactionPrice;

            await _accountDataService.Update(buyer.id, buyer);

            return buyer;
        }
    }
}
