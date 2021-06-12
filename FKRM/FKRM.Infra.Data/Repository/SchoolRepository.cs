using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FKRM.Infra.Data.Repository
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        public SchoolRepository(SchoolDBContext context) : base(context)
        {
        }

        public IQueryable<School> GetAllWithCode()
        {
            
            return DbSet.Select(p => new School()
            {
                Id = p.Id,
                Name = p.Name + " - " + p.Code,
                Gender = p.Gender,
                Feature = p.Feature,
                OUType = p.OUType,
                UnitType = p.UnitType,
                Code = p.Code,
                District = p.District,
                Subsidiary = p.Subsidiary,
                Branch = p.Branch
            });
        }
    }
}
