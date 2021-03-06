﻿using ClassLibrary1.Services;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraderEntityFrameWork.Services.Common;

namespace TraderEntityFrameWork.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly DbContextOptionsFactory _context;
        private readonly NonQueryDataService<T> _nonQueryDataService; 
        public GenericDataService(DbContextOptionsFactory context)
        {
            _context = context;
            _nonQueryDataService = new NonQueryDataService<T>(_context);
        }

        public async Task<T> Create(T entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<T> Get(int Id)
        {
            using (TraderDbContext context = _context.CreateDbContext())
            {
                T entity = await context.Set<T>().FirstOrDefaultAsync(e => e.id == Id);
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (TraderDbContext context = _context.CreateDbContext())
            {
                IEnumerable<T> entity = await context.Set<T>().ToListAsync();
                return entity;

            }
        }

        public async Task<T> Update(int id, T entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
