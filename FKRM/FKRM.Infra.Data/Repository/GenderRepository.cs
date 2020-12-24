using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
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

        public IEnumerable<Gender> GetGenders()
        {
            return _ctx.Genders;
        }
    }
}
