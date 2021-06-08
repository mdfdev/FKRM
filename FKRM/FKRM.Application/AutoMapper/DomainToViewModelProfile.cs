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
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<AcademicDegree, AcademicDegreeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<AcademicMajor, AcademicMajorViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Area, AreaViewModel>()
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Branch.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Branch, BranchViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Course, CourseViewModel>()
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Major.Group.Area.Branch.Name))
                .ForMember(cd => cd.Area, opt => opt.MapFrom(c => c.Major.Group.Area.Name))
                .ForMember(cd => cd.Group, opt => opt.MapFrom(c => c.Major.Group.Name))
                .ForMember(cd => cd.Major, opt => opt.MapFrom(c => c.Major.Name))
                .ForMember(cd => cd.Grade, opt => opt.MapFrom(c => c.Grade.Name))
                .ForMember(cd => cd.MarkingType, opt => opt.MapFrom(c => c.MarkingType.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<District, DistrictViewModel>()
              .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
              .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Enrollment, EnrollmentViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Feature, FeatureViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Gender, GenderViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Grade, GradeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Group, GroupViewModel>()
                .ForMember(cd => cd.Area, opt => opt.MapFrom(c => c.Area.Name))
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Area.Branch.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Major, MajorViewModel>()
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Group.Area.Branch.Name))
                .ForMember(cd => cd.Area, opt => opt.MapFrom(c => c.Group.Area.Name))
                .ForMember(cd => cd.Group, opt => opt.MapFrom(c => c.Group.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<MarkingType, MarkingTypeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));

            CreateMap<Notification, NotificationViewModel>()
                .ForMember(cd => cd.ParentNotification, opt => opt.MapFrom(c => c.ParentNotification.Subject))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPriorDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));

            CreateMap<OUType, OUTypeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
           
            CreateMap<JobTitle, JobTitleViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<School, SchoolViewModel>()
                .ForMember(cd => cd.Branch, opt => opt.MapFrom(c => c.Branch.Name))
                .ForMember(cd => cd.ParentSchool, opt => opt.MapFrom(c => c.Subsidiary.Name))
                .ForMember(cd => cd.District, opt => opt.MapFrom(c => c.District.Name))
                .ForMember(cd => cd.Gender, opt => opt.MapFrom(c => c.Gender.Name))
                .ForMember(cd => cd.Feature, opt => opt.MapFrom(c => c.Feature.Name))
                .ForMember(cd => cd.OUType, opt => opt.MapFrom(c => c.OUType.Name))
                .ForMember(cd => cd.UnitType, opt => opt.MapFrom(c => c.UnitType.Name))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<Staff, StaffViewModel>()
                .ForMember(cd => cd.JobTitle, opt => opt.MapFrom(c => c.JobTitle.Title))
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
            CreateMap<UnitType, UnitTypeViewModel>()
                .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
                .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));

            CreateMap<WorkedFor, WorkedForViewModel>()
               .ForMember(cd => cd.AddedDate, opt => opt.MapFrom(c => c.AddedDate.ToPersianDate()))
               .ForMember(cd => cd.ModifiedDate, opt => opt.MapFrom(c => c.ModifiedDate.ToPersianDate()));
        }
    }
}
