using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class MarkingTypeService : IMarkingTypeService
    {
        private IMarkingTypeRepository _markingTypeRepository;
        public MarkingTypeService(IMarkingTypeRepository repository)
        {
            _markingTypeRepository = repository;
        }
        public MarkingTypeViewModel GetMarkingTypes()
        {
            return new MarkingTypeViewModel()
            {
                markingTypes = _markingTypeRepository.GetMarkingTypes()
            };
        }
    }
}
