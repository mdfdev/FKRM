using AutoMapper;
using FKRM.Application.ViewModels;
using FKRM.Application.Commands.AcademicCalendar;
using FKRM.Application.Commands.Area;
using FKRM.Application.Commands.Branch;
using FKRM.Application.Commands.Course;
using FKRM.Application.Commands.Enrollment;
using FKRM.Application.Commands.Feature;
using FKRM.Application.Commands.Gender;
using FKRM.Application.Commands.Grade;
using FKRM.Application.Commands.Group;
using FKRM.Application.Commands.Major;
using FKRM.Application.Commands.MarkingType;
using FKRM.Application.Commands.OUType;
using FKRM.Application.Commands.JobTitle;
using FKRM.Application.Commands.School;
using FKRM.Application.Commands.Staff;
using FKRM.Application.Commands.UnitType;
using System;
using FKRM.Application.Commands.WorkedFor;
using FKRM.Application.Commands.District;
using FKRM.Application.Commands.AcademicDegree;
using FKRM.Application.Commands.AcademicMajor;
using FKRM.Application.Commands.Notification;
using FKRM.Application.Commands.StaffEducationalBackground;

namespace FKRM.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            //CreateMap<AreaViewModel, GetAreaByIdQuery>().ConstructUsing(c => new GetAreaByIdQuery(c.Id));

            CreateMap<AcademicCalendarViewModel, CreateAcademicCalendarCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateAcademicCalendarCommand(c.AcademicYear, c.AcademicQuarter));
            CreateMap<AcademicCalendarViewModel, UpdateAcademicCalendarCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateAcademicCalendarCommand(c.Id, c.AcademicYear, c.AcademicQuarter));
            CreateMap<AcademicCalendarViewModel, DeleteAcademicCalendarCommand>()
                .ConstructUsing(c => new DeleteAcademicCalendarCommand(c.Id));
            //---------------------------------------------------
            CreateMap<AcademicDegreeViewModel, CreateAcademicDegreeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateAcademicDegreeCommand(c.Name));
            CreateMap<AcademicDegreeViewModel, UpdateAcademicDegreeCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateAcademicDegreeCommand(c.Id, c.Name));
            CreateMap<AcademicDegreeViewModel, DeleteAcademicDegreeCommand>()
                .ConstructUsing(c => new DeleteAcademicDegreeCommand(c.Id));
            //---------------------------------------------------
            CreateMap<AcademicMajorViewModel, CreateAcademicMajorCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateAcademicMajorCommand(c.Name));
            CreateMap<AcademicMajorViewModel, UpdateAcademicMajorCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateAcademicMajorCommand(c.Id, c.Name));
            CreateMap<AcademicMajorViewModel, DeleteAcademicMajorCommand>()
                .ConstructUsing(c => new DeleteAcademicMajorCommand(c.Id));
            //---------------------------------------------------
            CreateMap<AreaViewModel, CreateAreaCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateAreaCommand(c.Name, c.BranchId));
            CreateMap<AreaViewModel, UpdateAreaCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateAreaCommand(c.Id, c.Name));
            CreateMap<AreaViewModel, DeleteAreaCommand>()
                .ConstructUsing(c => new DeleteAreaCommand(c.Id));
            //---------------------------------------------------
            CreateMap<AreaViewModel, CreateAreaCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateAreaCommand(c.Name,c.BranchId));
            CreateMap<AreaViewModel, UpdateAreaCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateAreaCommand(c.Id, c.Name));
            CreateMap<AreaViewModel, DeleteAreaCommand>()
                .ConstructUsing(c => new DeleteAreaCommand(c.Id));
            //---------------------------------------------------
            CreateMap<BranchViewModel, CreateBranchCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateBranchCommand(c.Name));
            CreateMap<BranchViewModel, UpdateBranchCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateBranchCommand(c.Id, c.Name));
            CreateMap<BranchViewModel, DeleteBranchCommand>()
                .ConstructUsing(c => new DeleteBranchCommand(c.Id));
            //---------------------------------------------------
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateCourseCommand(c.Name,c.Code,c.Credits,c.PassMark,c.MajorId,c.GradeId,c.MarkingTypeId,c.PracticalWeeklyHours,c.TheoreticalWeeklyHours));
            CreateMap<CourseViewModel, UpdateCourseCommand>()
               .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
               .ConstructUsing(c => new UpdateCourseCommand(c.Id, c.Name,c.Code,c.Credits,c.PassMark,c.MajorId,c.GradeId,c.MarkingTypeId,c.PracticalWeeklyHours,c.TheoreticalWeeklyHours));
            CreateMap<CourseViewModel, DeleteCourseCommand>()
               .ConstructUsing(c => new DeleteCourseCommand(c.Id));
            //---------------------------------------------------
            CreateMap<DistrictViewModel, CreateDistrictCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateDistrictCommand(c.Name));
            CreateMap<DistrictViewModel, UpdateDistrictCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateDistrictCommand(c.Id, c.Name));
            CreateMap<DistrictViewModel, DeleteDistrictCommand>()
                .ConstructUsing(c => new DeleteDistrictCommand(c.Id));
            //---------------------------------------------------
            CreateMap<EnrollmentViewModel, CreateEnrollmentCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateEnrollmentCommand(c.Capacity));
            CreateMap<EnrollmentViewModel, UpdateEnrollmentCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateEnrollmentCommand(c.Id, c.Capacity));
            CreateMap<EnrollmentViewModel, DeleteEnrollmentCommand>()
                .ConstructUsing(c => new DeleteEnrollmentCommand(c.Id));
            //---------------------------------------------------
            CreateMap<FeatureViewModel, CreateFeatureCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateFeatureCommand(c.Name));
            CreateMap<FeatureViewModel, UpdateFeatureCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateFeatureCommand(c.Id, c.Name));
            CreateMap<FeatureViewModel, DeleteFeatureCommand>()
                .ConstructUsing(c => new DeleteFeatureCommand(c.Id));
            //---------------------------------------------------
            CreateMap<GenderViewModel, CreateGenderCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateGenderCommand(c.Name));
            CreateMap<GenderViewModel, UpdateGenderCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateGenderCommand(c.Id, c.Name));
            CreateMap<GenderViewModel, DeleteGenderCommand>()
                .ConstructUsing(c => new DeleteGenderCommand(c.Id));
            //---------------------------------------------------
            CreateMap<GradeViewModel, CreateGradeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateGradeCommand(c.Name));
            CreateMap<GradeViewModel, UpdateGradeCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateGradeCommand(c.Id, c.Name));
            CreateMap<GradeViewModel, DeleteGradeCommand>()
                .ConstructUsing(c => new DeleteGradeCommand(c.Id));
            //---------------------------------------------------
            CreateMap<GroupViewModel, CreateGroupCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateGroupCommand(c.Name,c.AreaId));
            CreateMap<GroupViewModel, UpdateGroupCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateGroupCommand(c.Id, c.Name));
            CreateMap<GroupViewModel, DeleteGroupCommand>()
                .ConstructUsing(c => new DeleteGroupCommand(c.Id));
            //---------------------------------------------------
            CreateMap<StaffViewModel, CreateStaffCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateStaffCommand(c.FirstName, c.LastName, c.Phone, c.Mobile, c.NationalCode, c.JobTitleId, c.SchoolId, c.AcademicCalendarId,
                c.BirthDate,c.HiringDate,c.Email,c.Bio));
            CreateMap<StaffViewModel, UpdateStaffCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateStaffCommand(c.Id, c.FirstName, c.LastName, c.Phone, c.Mobile, c.NationalCode,c.JobTitleId,
                c.BirthDate, c.HiringDate, c.Email, c.Bio));
            CreateMap<StaffViewModel, DeleteStaffCommand>()
                .ConstructUsing(c => new DeleteStaffCommand(c.Id));
            //---------------------------------------------------
            CreateMap<StaffEducationalBackgroundViewModel, CreateStaffEducationalBackgroundCommand>()
              .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
              .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
              .ConstructUsing(c => new CreateStaffEducationalBackgroundCommand(c.StaffId,c.AcademicDegreeId,c.AcademicMajorId));
            //---------------------------------------------------
            CreateMap<MajorViewModel, CreateMajorCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateMajorCommand(c.Name, c.ComputerCode, c.RequiredCredit, c.OptionalElectiveCredit, c.GraduationCredits, c.GroupId));
            CreateMap<MajorViewModel, UpdateMajorCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateMajorCommand(c.Id, c.Name, c.ComputerCode, c.RequiredCredit, c.OptionalElectiveCredit, c.GraduationCredits,c.GroupId));
            CreateMap<MajorViewModel, DeleteMajorCommand>()
                .ConstructUsing(c => new DeleteMajorCommand(c.Id));
            //---------------------------------------------------
            CreateMap<MarkingTypeViewModel, CreateMarkingTypeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateMarkingTypeCommand(c.Name));
            CreateMap<MarkingTypeViewModel, UpdateMarkingTypeCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateMarkingTypeCommand(c.Id, c.Name));
            CreateMap<MarkingTypeViewModel, DeleteMarkingTypeCommand>()
                .ConstructUsing(c => new DeleteMarkingTypeCommand(c.Id));
            //--------------------------------------------------
            CreateMap<NotificationViewModel, CreateNotificationCommand>()
              .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
              .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
              .ConstructUsing(c => new CreateNotificationCommand(c.Subject,c.Body));

            CreateMap<NotificationViewModel, UpdateNotificationCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateNotificationCommand(c.Id, c.Subject,c.Body));

            CreateMap<NotificationViewModel, DeleteNotificationCommand>()
                .ConstructUsing(c => new DeleteNotificationCommand(c.Id));
            //---------------------------------------------------
            CreateMap<OUTypeViewModel, CreateOUTypeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateOUTypeCommand(c.Name));
            CreateMap<OUTypeViewModel, UpdateOUTypeCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateOUTypeCommand(c.Id, c.Name));
            CreateMap<OUTypeViewModel, DeleteOUTypeCommand>()
                .ConstructUsing(c => new DeleteOUTypeCommand(c.Id));
            //---------------------------------------------------
            CreateMap<JobTitleViewModel, CreateJobTitleCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateJobTitleCommand(c.Title));
            CreateMap<JobTitleViewModel, UpdateJobTitleCommand>()
               .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
               .ConstructUsing(c => new UpdateJobTitleCommand(c.Id, c.Title));
            CreateMap<JobTitleViewModel, DeleteJobTitleCommand>()
               .ConstructUsing(c => new DeleteJobTitleCommand(c.Id));
            //---------------------------------------------------
            CreateMap<SchoolViewModel, CreateSchoolCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateSchoolCommand(c.Name, c.Code, c.GenderId, c.FeatureId, c.UnitTypeId, c.OUTypeId,c.DistrictId,c.ParentSchoolId,c.HasParentSchool,c.BranchId));
            CreateMap<SchoolViewModel, UpdateSchoolCommand>()
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new UpdateSchoolCommand(c.Id, c.Name,c.Code,c.GenderId,c.FeatureId,c.UnitTypeId,c.OUTypeId,c.DistrictId, c.ParentSchoolId,c.HasParentSchool,c.BranchId));
            CreateMap<SchoolViewModel, DeleteSchoolCommand>()
                .ConstructUsing(c => new DeleteSchoolCommand(c.Id));
            //---------------------------------------------------
            CreateMap<UnitTypeViewModel, CreateUnitTypeCommand>()
                .ForMember(c => c.AddedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
                .ConstructUsing(c => new CreateUnitTypeCommand(c.Name));
            CreateMap<UnitTypeViewModel, UpdateUnitTypeCommand>()
               .ForMember(c => c.ModifiedDate, opt => opt.MapFrom(_ => DateTime.Now))
               .ConstructUsing(c => new UpdateUnitTypeCommand(c.Id, c.Name));
            CreateMap<UnitTypeViewModel, DeleteUnitTypeCommand>()
               .ConstructUsing(c => new DeleteUnitTypeCommand(c.Id));
            //---------------------------------------------------
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
