using ClassLibrary1.Services;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TraderEntityFrameWork.Services.Common;

namespace TraderEntityFrameWork.Services
{
    public class AccountDataService : IDataService<Account>
    {
        private readonly DbContextOptionsFactory _context;
        private readonly NonQueryDataService<Account> _nonQueryDataService;

        public AccountDataService(DbContextOptionsFactory context)
        {
            _context = context;
            _nonQueryDataService = new NonQueryDataService<Account>(_context);
        }

        public async Task<Account> Create(Account entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<Account> Get(int Id)
        {
            using (TraderDbContext context = _context.CreateDbContext())
            {
                Account entity = await context.Accounts.Include(a => a.AssetTransactions).FirstOrDefaultAsync(e => e.id == Id);
                return entity;
            }
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            using (TraderDbContext context = _context.CreateDbContext())
            {
                IEnumerable<Account> entity = await context.Accounts.Include(a => a.AssetTransactions).ToListAsync();
                return entity;

            }
        }

        public async Task<Account> Update(int id, Account entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
