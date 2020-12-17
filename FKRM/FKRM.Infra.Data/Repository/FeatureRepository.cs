using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;
using System;
using System.Collections.Generic;
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
        public IEnumerable<Feature> GetFeatures()
        {
            return _ctx.Features;
        }
    }
}
