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
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Major.Group.Area.Branch.Name))
                .ForMember(cd => cd.Area, opt => opt.MapFrom(c => c.Major.Group.Area.Name))
                .ForMember(cd => cd.Group, opt => opt.MapFrom(c => c.Major.Group.Name))
                .ForMember(cd => cd.Major, opt => opt.MapFrom(c => c.Major.Name))
                .ForMember(cd => cd.Grade, opt => opt.MapFrom(c => c.Grade.Name))
                .ForMember(cd => cd.MarkingType, opt => opt.MapFrom(c => c.MarkingType.Name))
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
           
            CreateMap<JobTitle, JobTitleViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<School, SchoolViewModel>()
                .ForMember(cd => cd.Gender, opt => opt.MapFrom(c => c.Gender.Name))
                .ForMember(cd => cd.Feature, opt => opt.MapFrom(c => c.Feature.Name))
                .ForMember(cd => cd.OUType, opt => opt.MapFrom(c => c.OUType.Name))
                .ForMember(cd => cd.UnitType, opt => opt.MapFrom(c => c.UnitType.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<Staff, StaffViewModel>()
                .ForMember(cd => cd.JobTitle, opt => opt.MapFrom(c => c.JobTitle.Title))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
            CreateMap<UnitType, UnitTypeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));

            CreateMap<WorkedFor, WorkedForViewModel>()
               .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToShamsiDateTime()))
               .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToShamsiDateTime()));
        }
    }
}
