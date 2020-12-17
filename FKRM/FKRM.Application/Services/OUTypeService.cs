using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class OUTypeService : IOUTypeService
    {
        private IOUTypeRepository _oUTypeRepository;
        public OUTypeService(IOUTypeRepository repository)
        {
            _oUTypeRepository = repository;
        }
        public OUTypeViewModel GetOUTypes()
        {
            return new OUTypeViewModel()
            {
                oUTypes = _oUTypeRepository.GetOUTypes()
            };
        }
    }
}
