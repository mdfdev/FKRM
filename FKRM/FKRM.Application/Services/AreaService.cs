using FKRM.Application.Interfaces;
using FKRM.Application.Interfaces.Repositories;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class AreaService : IAreaService
    {
        private IAreaRepository _areaRepository;
        public AreaService(IAreaRepository repository)
        {
            _areaRepository = repository;
        }
        public AreaViewModel GetAreas()
        {
            return new AreaViewModel()
            {
                areas = _areaRepository.GetAreas()
            };
        }
    }
}
