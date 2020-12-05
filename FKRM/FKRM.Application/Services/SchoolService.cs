using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class SchoolService : ISchoolService
    {
        private ISchoolRepository _schoolRepository;
        public SchoolService(ISchoolRepository repository)
        {
            _schoolRepository = repository;
        }
        public SchoolViewModel  GetSchools()
        {
            return new SchoolViewModel()
            {
                Schools = _schoolRepository.GetSchools()
            };
        }
    }
}
