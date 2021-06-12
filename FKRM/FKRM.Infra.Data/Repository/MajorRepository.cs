using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class MajorRepository : Repository<Major>, IMajorRepository
    {
        public MajorRepository(SchoolDBContext context) : base(context)
        {
        }
        public IQueryable<Major> GetAllByGroupId(Guid id)
        {
            return DbSet.Where(p => p.GroupId == id);
        }
    }
}
