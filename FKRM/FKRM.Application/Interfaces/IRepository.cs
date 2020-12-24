using FKRM.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FKRM.Application.Interfaces
{
    public interface IRepository
    {
        Task<T> GetByIdAsync<T>(int id) where T : IEntity;
        Task<List<T>> ListAsync<T>() where T : IEntity;
        Task<T> AddAsync<T>(T entity) where T : IEntity;
        Task UpdateAsync<T>(T entity) where T : IEntity;
        Task DeleteAsync<T>(T entity) where T : IEntity;
    }
}
