using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FKRM.Infra.Data.Repository
{
    public class FeatureRepository : IFeatureRepository
    {
        private SchoolDBContext _ctx;
        public FeatureRepository(SchoolDBContext context)
        {
            _ctx = context;
        }
        public void Add(Feature feature)
        {
            _ctx.Add(feature);
            _ctx.SaveChanges();
        }

        public IQueryable<Feature> GetFeatures()
        {
            return _ctx.Features;
        }
    }
}
