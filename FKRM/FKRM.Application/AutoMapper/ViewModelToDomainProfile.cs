using AutoMapper;
using FKRM.Application.ViewModels;
using FKRM.Domain.Commands.AcademicCalendar;
using FKRM.Domain.Commands.Area;
using FKRM.Domain.Commands.Branch;
using FKRM.Domain.Commands.Course;
using FKRM.Domain.Commands.Enrollment;
using FKRM.Domain.Commands.Feature;
using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Commands.Grade;
using FKRM.Domain.Commands.Group;
using FKRM.Domain.Commands.Major;
using FKRM.Domain.Commands.MarkingType;
using FKRM.Domain.Commands.OUType;
using FKRM.Domain.Commands.Room;
using FKRM.Domain.Commands.Schedule;
using FKRM.Domain.Commands.School;
using FKRM.Domain.Commands.Staff;
using FKRM.Domain.Commands.UnitType;
using FKRM.Domain.Queries.Area;
using System;

namespace FKRM.Application.AutoMapper
{
    public class ViewModelToDomainProfile:Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<AreaViewModel, GetAreaByIdQuery>().ConstructUsing(c => new  GetAreaByIdQuery(c.Id));
            CreateMap<AcademicCalendarViewModel, CreateAcademicCalendarCommand>().ConstructUsing(c => new CreateAcademicCalendarCommand(c.AcademicYear,c.AcademicQuarter));

            CreateMap<AreaViewModel, CreateAreaCommand>()
                //.ForPath(c => c.Address.Province, d => d.MapFrom(d => d.Branch))
                .ConstructUsing(c => new CreateAreaCommand(c.Name));
            CreateMap<AreaViewModel, UpdateAreaCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateAreaCommand(c.Id, c.Name));

            CreateMap<BranchViewModel, CreateBranchCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateBranchCommand(c.Name));
            CreateMap<BranchViewModel, UpdateBranchCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateBranchCommand(c.Id,c.Name));

            CreateMap<CourseViewModel, CreateCourseCommand>().ConstructUsing(c => new CreateCourseCommand(c.Name));
            CreateMap<EnrollmentViewModel, CreateEnrollmentCommand>().ConstructUsing(c => new CreateEnrollmentCommand(c.Capacity));
            CreateMap<FeatureViewModel, CreateFeatureCommand>().ConstructUsing(c => new CreateFeatureCommand(c.Name));
            CreateMap<GenderViewModel, CreateGenderCommand>().ConstructUsing(c => new CreateGenderCommand(c.Name));
            CreateMap<GradeViewModel, CreateGradeCommand>().ConstructUsing(c => new CreateGradeCommand(c.Name));
            CreateMap<GroupViewModel, CreateGroupCommand>().ConstructUsing(c => new CreateGroupCommand(c.Name));
            CreateMap<StaffViewModel, UpdateStaffCommand>().ConstructUsing(c => new UpdateStaffCommand(c.Id, c.FirstName, c.LastName, c.Phone, c.Mobile, c.NationalCode));
            CreateMap<MajorViewModel, CreateMajorCommand>().ConstructUsing(c => new CreateMajorCommand(c.Name,c.ComputerCode,c.RequiredCredit,c.OptionalElectiveCredit,c.GraduationCredits));
            CreateMap<MarkingTypeViewModel, CreateMarkingTypeCommand>().ConstructUsing(c => new CreateMarkingTypeCommand(c.Name));
            CreateMap<OUTypeViewModel, CreateOUTypeCommand>().ConstructUsing(c => new CreateOUTypeCommand(c.Name));
            CreateMap<RoomViewModel, CreateRoomCommand>().ConstructUsing(c => new CreateRoomCommand(c.Name));
            CreateMap<ScheduleViewModel, CreateScheduleCommand>().ConstructUsing(c => new CreateScheduleCommand(c.StartTime));
            CreateMap<SchoolViewModel, CreateSchoolCommand>().ConstructUsing(c => new CreateSchoolCommand(c.Id,c.Name));
            CreateMap<StaffViewModel, CreateStaffCommand>().ConstructUsing(c => new CreateStaffCommand(c.FirstName, c.LastName, c.Phone, c.Mobile, c.NationalCode));
            CreateMap<UnitTypeViewModel, CreateUnitTypeCommand>().ConstructUsing(c => new CreateUnitTypeCommand(c.Name));
        }
    }
}
