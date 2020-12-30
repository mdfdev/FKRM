using AutoMapper;
using FKRM.Application.ViewModels;
using FKRM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Application.AutoMapper
{
    public class DomainToViewModelProfile:Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<AcademicCalendar, AcademicCalendarViewModel>();
            CreateMap<Area, AreaViewModel>();
            CreateMap<Branch, BranchViewModel>();
            CreateMap<Course, CourseViewModel>();
            CreateMap<Enrollment, EnrollmentViewModel>();
            CreateMap<Feature, FeatureViewModel>();
            CreateMap<Gender,GenderViewModel>();
            CreateMap<Grade, GradeViewModel>();
            CreateMap<Group, GroupViewModel>();
            CreateMap<Major, MajorViewModel>();
            CreateMap<MarkingType, MarkingTypeViewModel>();
            CreateMap<OUType, OUTypeViewModel>();
            CreateMap<Room,  RoomViewModel>();
            CreateMap<Schedule, ScheduleViewModel>();
            CreateMap<School, SchoolViewModel>();
            CreateMap<Staff, StaffViewModel>();
            CreateMap<UnitType, UnitTypeViewModel>();
        }
    }
}
