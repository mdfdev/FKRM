using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class MajorService : IMajorService
    {
        private IMajorRepository _majorRepository;
        public MajorService(IMajorRepository repository)
        {
            _majorRepository = repository;
        }
        public MajorViewModel GetMajors()
        {
            return new MajorViewModel()
            {
                majors = _majorRepository.GetMajors()
            };
        }
    }
}
