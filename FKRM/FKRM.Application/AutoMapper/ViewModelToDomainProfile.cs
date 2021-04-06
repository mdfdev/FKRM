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
using FKRM.Domain.Commands.JobTitle;
using FKRM.Domain.Commands.School;
using FKRM.Domain.Commands.Staff;
using FKRM.Domain.Commands.UnitType;
using FKRM.Domain.Queries.Area;
using System;
using FKRM.Domain.Commands.WorkedFor;

namespace FKRM.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<AreaViewModel, GetAreaByIdQuery>().ConstructUsing(c => new GetAreaByIdQuery(c.Id));

            CreateMap<AcademicCalendarViewModel, CreateAcademicCalendarCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateAcademicCalendarCommand(c.AcademicYear, c.AcademicQuarter));
            CreateMap<AcademicCalendarViewModel, UpdateAcademicCalendarCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateAcademicCalendarCommand(c.Id, c.AcademicYear, c.AcademicQuarter));
            CreateMap<AcademicCalendarViewModel, DeleteAcademicCalendarCommand>()
                .ConstructUsing(c => new DeleteAcademicCalendarCommand(c.Id));

            CreateMap<AreaViewModel, CreateAreaCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateAreaCommand(c.Name,c.BranchId));
            CreateMap<AreaViewModel, UpdateAreaCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateAreaCommand(c.Id, c.Name));
            CreateMap<AreaViewModel, DeleteAreaCommand>()
                .ConstructUsing(c => new DeleteAreaCommand(c.Id));

            CreateMap<BranchViewModel, CreateBranchCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateBranchCommand(c.Name));
            CreateMap<BranchViewModel, UpdateBranchCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateBranchCommand(c.Id, c.Name));
            CreateMap<BranchViewModel, DeleteBranchCommand>()
                .ConstructUsing(c => new DeleteBranchCommand(c.Id));

            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateCourseCommand(c.Name,c.Code,c.Credits,c.PassMark,c.MajorId,c.GradeId,c.MarkingTypeId,c.PracticalWeeklyHours,c.TheoreticalWeeklyHours));
            CreateMap<CourseViewModel, UpdateCourseCommand>()
               .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
               .ConstructUsing(c => new UpdateCourseCommand(c.Id, c.Name,c.Code,c.Credits,c.PassMark,c.MajorId,c.GradeId,c.MarkingTypeId,c.PracticalWeeklyHours,c.TheoreticalWeeklyHours));
            CreateMap<CourseViewModel, DeleteCourseCommand>()
               .ConstructUsing(c => new DeleteCourseCommand(c.Id));

            CreateMap<EnrollmentViewModel, CreateEnrollmentCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateEnrollmentCommand(c.Capacity));
            CreateMap<EnrollmentViewModel, UpdateEnrollmentCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateEnrollmentCommand(c.Id, c.Capacity));
            CreateMap<EnrollmentViewModel, DeleteEnrollmentCommand>()
                .ConstructUsing(c => new DeleteEnrollmentCommand(c.Id));

            CreateMap<FeatureViewModel, CreateFeatureCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateFeatureCommand(c.Name));
            CreateMap<FeatureViewModel, UpdateFeatureCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateFeatureCommand(c.Id, c.Name));
            CreateMap<FeatureViewModel, DeleteFeatureCommand>()
                .ConstructUsing(c => new DeleteFeatureCommand(c.Id));

            CreateMap<GenderViewModel, CreateGenderCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateGenderCommand(c.Name));
            CreateMap<GenderViewModel, UpdateGenderCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateGenderCommand(c.Id, c.Name));
            CreateMap<GenderViewModel, DeleteGenderCommand>()
                .ConstructUsing(c => new DeleteGenderCommand(c.Id));

            CreateMap<GradeViewModel, CreateGradeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateGradeCommand(c.Name));
            CreateMap<GradeViewModel, UpdateGradeCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateGradeCommand(c.Id, c.Name));
            CreateMap<GradeViewModel, DeleteGradeCommand>()
                .ConstructUsing(c => new DeleteGradeCommand(c.Id));

            CreateMap<GroupViewModel, CreateGroupCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateGroupCommand(c.Name,c.AreaId));
            CreateMap<GroupViewModel, UpdateGroupCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateGroupCommand(c.Id, c.Name));
            CreateMap<GroupViewModel, DeleteGroupCommand>()
                .ConstructUsing(c => new DeleteGroupCommand(c.Id));

            CreateMap<StaffViewModel, CreateStaffCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateStaffCommand(c.FirstName, c.LastName, c.Phone, c.Mobile, c.NationalCode,c.JobTitleId));
            CreateMap<StaffViewModel, UpdateStaffCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateStaffCommand(c.Id, c.FirstName, c.LastName, c.Phone, c.Mobile, c.NationalCode,c.JobTitleId));
            CreateMap<StaffViewModel, DeleteStaffCommand>()
                .ConstructUsing(c => new DeleteStaffCommand(c.Id));

            CreateMap<MajorViewModel, CreateMajorCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateMajorCommand(c.Name, c.ComputerCode, c.RequiredCredit, c.OptionalElectiveCredit, c.GraduationCredits, c.GroupId));
            CreateMap<MajorViewModel, UpdateMajorCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateMajorCommand(c.Id, c.Name, c.ComputerCode, c.RequiredCredit, c.OptionalElectiveCredit, c.GraduationCredits,c.GroupId));
            CreateMap<MajorViewModel, DeleteMajorCommand>()
                .ConstructUsing(c => new DeleteMajorCommand(c.Id));

            CreateMap<MarkingTypeViewModel, CreateMarkingTypeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateMarkingTypeCommand(c.Name));
            CreateMap<MarkingTypeViewModel, UpdateMarkingTypeCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateMarkingTypeCommand(c.Id, c.Name));
            CreateMap<MarkingTypeViewModel, DeleteMarkingTypeCommand>()
                .ConstructUsing(c => new DeleteMarkingTypeCommand(c.Id));

            CreateMap<OUTypeViewModel, CreateOUTypeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateOUTypeCommand(c.Name));
            CreateMap<OUTypeViewModel, UpdateOUTypeCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateOUTypeCommand(c.Id, c.Name));
            CreateMap<OUTypeViewModel, DeleteOUTypeCommand>()
                .ConstructUsing(c => new DeleteOUTypeCommand(c.Id));

            CreateMap<JobTitleViewModel, CreateJobTitleCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateJobTitleCommand(c.Title));
            CreateMap<JobTitleViewModel, UpdateJobTitleCommand>()
               .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
               .ConstructUsing(c => new UpdateJobTitleCommand(c.Id, c.Title));
            CreateMap<JobTitleViewModel, DeleteJobTitleCommand>()
               .ConstructUsing(c => new DeleteJobTitleCommand(c.Id));

            CreateMap<SchoolViewModel, CreateSchoolCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateSchoolCommand(c.Name, c.Code, c.GenderId, c.FeatureId, c.UnitTypeId, c.OUTypeId));
            CreateMap<SchoolViewModel, UpdateSchoolCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateSchoolCommand(c.Id, c.Name,c.Code,c.GenderId,c.FeatureId,c.UnitTypeId,c.OUTypeId));
            CreateMap<SchoolViewModel, DeleteSchoolCommand>()
                .ConstructUsing(c => new DeleteSchoolCommand(c.Id));

            CreateMap<UnitTypeViewModel, CreateUnitTypeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateUnitTypeCommand(c.Name));
            CreateMap<UnitTypeViewModel, UpdateUnitTypeCommand>()
               .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
               .ConstructUsing(c => new UpdateUnitTypeCommand(c.Id, c.Name));
            CreateMap<UnitTypeViewModel, DeleteUnitTypeCommand>()
               .ConstructUsing(c => new DeleteUnitTypeCommand(c.Id));

            CreateMap<WorkedForViewModel, CreateWorkedForCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now));
            CreateMap<WorkedForViewModel, UpdateWorkedForCommand>()
               .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now));
            CreateMap<WorkedForViewModel, DeleteWorkedForCommand>()
               .ConstructUsing(c => new DeleteWorkedForCommand(c.Id));
        }
    }
}
