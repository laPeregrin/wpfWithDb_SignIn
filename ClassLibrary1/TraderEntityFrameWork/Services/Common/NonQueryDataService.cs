using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraderEntityFrameWork.Services.Common
{
    public class NonQueryDataService<T> where T : DomainObject
    {
        private readonly DbContextOptionsFactory _context;

        public NonQueryDataService(DbContextOptionsFactory context)
        {
            _context = context;
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
        public async Task<T> Create(T entity)
        {
            using (TraderDbContext context = _context.CreateDbContext())
            {
                EntityEntry<T> createEntity = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();
                return createEntity.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (TraderDbContext context = _context.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.id == id);
                context.Set<T>().Remove(entity);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (TraderDbContext context = _context.CreateDbContext())
            {
                entity.id = id;
                context.Set<T>().Update(entity);
                await context.SaveChangesAsync();
                return entity;
            }
        }

    }
}
