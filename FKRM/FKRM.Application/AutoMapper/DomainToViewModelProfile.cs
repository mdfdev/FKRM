using AutoMapper;
using FKRM.Application.Extension;
using FKRM.Application.ViewModels;
using FKRM.Domain.Entities;

namespace FKRM.Application.AutoMapper
{
    public class DomainToViewModelProfile:Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<AcademicCalendar, AcademicCalendarViewModel>();
            CreateMap<Area, AreaViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()));
            CreateMap<Branch, BranchViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
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
