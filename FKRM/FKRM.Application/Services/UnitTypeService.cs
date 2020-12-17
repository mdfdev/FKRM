using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class UnitTypeService : IUnitTypeService
    {
        private IUnitTypeRepository _unitTypeRepository;
        public UnitTypeService(IUnitTypeRepository repository)
        {
            _unitTypeRepository = repository;
        }
        public UnitTypeViewModel GetUnitTypes()
        {
            return new UnitTypeViewModel()
            {
                unitTypes = _unitTypeRepository.GetUnitTypes()
            };
        }
    }
}
