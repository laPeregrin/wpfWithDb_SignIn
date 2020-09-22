using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.TransactionServices
{
    public interface IBuyStockService
    {
        Task<Account> BuyStock(Account buyer, string stock, int shares);
    }
}
