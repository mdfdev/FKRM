using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Data.Context;

namespace FKRM.Infra.Data.Repository
{
    public class FeatureRepository :Repository<Feature>, IFeatureRepository
    {
        public FeatureRepository(SchoolDBContext context):base(context)
        {
            
        }
    }
}
