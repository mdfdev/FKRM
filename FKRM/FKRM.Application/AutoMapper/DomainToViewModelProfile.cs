using AutoMapper;
using FKRM.Application.Extension;
using FKRM.Application.ViewModels;
using FKRM.Domain.Entities;

namespace FKRM.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<AcademicCalendar, AcademicCalendarViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Area, AreaViewModel>()
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Branch.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Branch, BranchViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Course, CourseViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Enrollment, EnrollmentViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Feature, FeatureViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Gender, GenderViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Grade, GradeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Group, GroupViewModel>()
                .ForMember(cd => cd.Area, opt => opt.MapFrom(c => c.Area.Name))
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Area.Branch.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Major, MajorViewModel>()
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Group.Area.Branch.Name))
                .ForMember(cd => cd.Area, opt => opt.MapFrom(c => c.Group.Area.Name))
                .ForMember(cd => cd.Group, opt => opt.MapFrom(c => c.Group.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<MarkingType, MarkingTypeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<OUType, OUTypeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Room, RoomViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Schedule, ScheduleViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<School, SchoolViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Staff, StaffViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<UnitType, UnitTypeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
        }
    }
}
