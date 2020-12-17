using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.ViewModels
{
    public class FeatureViewModel
    {
        public IEnumerable<Feature> features  { get; set; }
    }
}
