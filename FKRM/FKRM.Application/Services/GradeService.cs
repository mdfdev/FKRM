using FKRM.Application.Interfaces;
using FKRM.Application.ViewModels;
using FKRM.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.Services
{
    public class GradeService : IGradeService
    {
        private IGradeRepository _gradeRepository;
        public GradeService(IGradeRepository repository)
        {
            _gradeRepository = repository;
        }
        public GradeViewModel GetGrades()
        {
            return new GradeViewModel()
            {
                grades = _gradeRepository.GetGrades()
            };
        }
    }
}
