using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class GenderRepository : IGenderRepository
    {
        private SchoolDBContext _ctx;
        public GenderRepository(SchoolDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Gender gender)
        {
            _ctx.Genders.Add(gender);
            _ctx.SaveChanges();
        }

        public void Delete(Gender gender)
        {
            _ctx.Genders.Remove(gender);
            _ctx.SaveChanges();
        }

        public Gender GetById(int id)
        {
            return  _ctx.Genders.Find(id);
        }

        public IQueryable<Gender> GetGenders()
        {
            return _ctx.Genders;
        }

        public IQueryable<Gender> GetPagedReponse(int pageNumber, int pageSize)
        {
            return  _ctx
                .Genders
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
        }

        public void Update(Gender gender)
        {
            _ctx.Entry(gender).State = EntityState.Modified;
            _ctx.SaveChanges();
        }
    }
}
