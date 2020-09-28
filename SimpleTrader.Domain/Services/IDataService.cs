using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Services
{
    public interface IDataService<T> where T : DomainObject
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task<T> Create(T entity);

        Task<T> Update(int id, T entity);

        Task<bool> Delete(int id);
    }
}
