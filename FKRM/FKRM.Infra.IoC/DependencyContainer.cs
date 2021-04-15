using FKRM.Application.Interfaces;
using FKRM.Application.Services;
using FKRM.Application.CommandHandlers;
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
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Interfaces;
using FKRM.Infra.Bus;
using FKRM.Infra.Data.Context;
using FKRM.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using FKRM.Application.Commands.WorkedFor;
using FKRM.Domain.Queries.Staff;
using System.Collections.Generic;
using FKRM.Application.ViewModels;
using FKRM.Domain.QueryHandlers;

namespace FKRM.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {


            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handler
            services.AddScoped<IRequestHandler<CreateAcademicCalendarCommand, Response<int>>, AcademicCalendarCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateAcademicCalendarCommand, Response<int>>, AcademicCalendarCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteAcademicCalendarCommand, Response<int>>, AcademicCalendarCommandHandler>();

            services.AddScoped<IRequestHandler<CreateAreaCommand, Response<int>>, AreaCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateAreaCommand, Response<int>>, AreaCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteAreaCommand, Response<int>>, AreaCommandHandler>();

            //services.AddScoped<IRequestHandler<GetAreaByIdQuery, Response<Area>>, AreaQueryHandler>();
            //services.AddScoped<IRequestHandler<GetAllAreaQuery, Response<IQueryable<Area>>>, AreaQueryHandler>();

            services.AddScoped<IRequestHandler<CreateBranchCommand, Response<int>>, BranchCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateBranchCommand, Response<int>>, BranchCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteBranchCommand, Response<int>>, BranchCommandHandler>();

            services.AddScoped<IRequestHandler<CreateCourseCommand, Response<int>>, CourseCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateCourseCommand, Response<int>>, CourseCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteCourseCommand, Response<int>>, CourseCommandHandler>();

            services.AddScoped<IRequestHandler<CreateEnrollmentCommand, Response<int>>, EnrollmentCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateEnrollmentCommand, Response<int>>, EnrollmentCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteEnrollmentCommand, Response<int>>, EnrollmentCommandHandler>();

            services.AddScoped<IRequestHandler<CreateFeatureCommand, Response<int>>, FeatureCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateFeatureCommand, Response<int>>, FeatureCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteFeatureCommand, Response<int>>, FeatureCommandHandler>();

            services.AddScoped<IRequestHandler<CreateGenderCommand, Response<int>>, GenderCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateGenderCommand, Response<int>>, GenderCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteGenderCommand, Response<int>>, GenderCommandHandler>();

            services.AddScoped<IRequestHandler<CreateGradeCommand, Response<int>>, GradeCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateGradeCommand, Response<int>>, GradeCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteGradeCommand, Response<int>>, GradeCommandHandler>();

            services.AddScoped<IRequestHandler<CreateGroupCommand, Response<int>>, GroupCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateGroupCommand, Response<int>>, GroupCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteGroupCommand, Response<int>>, GroupCommandHandler>();

            services.AddScoped<IRequestHandler<CreateMajorCommand, Response<int>>, MajorCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateMajorCommand, Response<int>>, MajorCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteMajorCommand, Response<int>>, MajorCommandHandler>();

            services.AddScoped<IRequestHandler<CreateMarkingTypeCommand, Response<int>>, MarkingTypeCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateMarkingTypeCommand, Response<int>>, MarkingTypeCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteMarkingTypeCommand, Response<int>>, MarkingTypeCommandHandler>();

            services.AddScoped<IRequestHandler<CreateOUTypeCommand, Response<int>>, OUTypeCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateOUTypeCommand, Response<int>>, OUTypeCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteOUTypeCommand, Response<int>>, OUTypeCommandHandler>();


            services.AddScoped<IRequestHandler<CreateJobTitleCommand, Response<int>>, JobTitleCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateJobTitleCommand, Response<int>>, JobTitleCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteJobTitleCommand, Response<int>>, JobTitleCommandHandler>();

            services.AddScoped<IRequestHandler<CreateSchoolCommand, Response<int>>, SchoolCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateSchoolCommand, Response<int>>, SchoolCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteSchoolCommand, Response<int>>, SchoolCommandHandler>();

            services.AddScoped<IRequestHandler<CreateStaffCommand, Response<int>>, StaffCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateStaffCommand, Response<int>>, StaffCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteStaffCommand, Response<int>>, StaffCommandHandler>();
            services.AddScoped<IRequestHandler<GetStaffAllData, Response<IEnumerable<StaffViewModel>>>, StaffQueryHandler>();

            services.AddScoped<IRequestHandler<CreateUnitTypeCommand, Response<int>>, UnitTypeCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateUnitTypeCommand, Response<int>>, UnitTypeCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteUnitTypeCommand, Response<int>>, UnitTypeCommandHandler>();

            services.AddScoped<IRequestHandler<CreateWorkedForCommand, Response<int>>, WorkedForCommandHandler>();
            services.AddScoped<IRequestHandler<UpdateWorkedForCommand, Response<int>>, WorkedForCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteWorkedForCommand, Response<int>>, WorkedForCommandHandler>();

            //Application Layer
            services.AddScoped<IAcademicCalendarService, AcademicCalendarService>();
            services.AddScoped<IAreaService, AreaService>();
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IEnrollmentService, EnrollmentService>();
            services.AddScoped<IFeatureService, FeatureService>();
            services.AddScoped<IGenderService, GenderService>();
            services.AddScoped<IGradeService, GradeService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IMajorService, MajorService>();
            services.AddScoped<IMarkingTypeService, MarkingTypeService>();
            services.AddScoped<IOUTypeService, OUTypeService>();
            services.AddScoped<IJobTitleService, JobTitleService>();
            services.AddScoped<ISchoolService, SchoolService>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<IUnitTypeService, UnitTypeService>();
            services.AddScoped<IWorkedForService, WorkedForService>();

            //Infra.Data.Layer
            services.AddScoped<IAcademicCalendarRepository, AcademicCalendarRepository>();
            services.AddScoped<IAreaRepository, AreaRepository>();
            services.AddScoped<IBranchRepository, BranchRepository>();
            services.AddScoped<ICourseRepository, CourseRepository>();
            services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<IGradeRepository, GradeRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<IMajorRepository, MajorRepository>();
            services.AddScoped<IMarkingTypeRepository, MarkingTypeRepository>();
            services.AddScoped<IOUTypeRepository, OUTypeRepository>();
            services.AddScoped<IJobTitleRepository, JobTitleRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IStaffRepository, StaffRepository>();
            services.AddScoped<IUnitTypeRepository, UnitTypeRepository>();
            services.AddScoped<IWorkedForRepository,WorkedForRepository>();
            services.AddScoped<SchoolDBContext>();


        }
    }
}
