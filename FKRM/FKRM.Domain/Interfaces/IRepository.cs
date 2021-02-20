﻿using System;
using System.Linq;

namespace FKRM.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
      
        TEntity GetById(Guid id);
       
        IQueryable<TEntity> GetAll();

        void Update(TEntity obj);
       
        void Remove(Guid id);
       
        int SaveChanges();
        IQueryable<TEntity> GetPagedReponse(int pageNumber, int pageSize);

    }
}
