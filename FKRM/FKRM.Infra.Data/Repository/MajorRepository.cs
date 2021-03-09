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
        private readonly DbSet<Major> _majors;

        public MajorRepository(SchoolDBContext context) : base(context)
        {
            _majors = context.Set<Major>();
        }
        public IQueryable<Major> GetAllByGroupId(Guid id)
        {
            return _majors.Where(p => p.GroupId == id);
        }
    }
}
