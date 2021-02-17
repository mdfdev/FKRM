using FKRM.Application.Interfaces;
using FKRM.Application.Services;
using FKRM.Domain.CommandHandlers;
using FKRM.Domain.Commands.Gender;
using FKRM.Domain.Commands.Major;
using FKRM.Domain.Commands.Staff;
using FKRM.Domain.Core.Bus;
using FKRM.Domain.Core.Wrappers;
using FKRM.Domain.Entities;
using FKRM.Domain.Interfaces;
using FKRM.Domain.Queries.Gender;
using FKRM.Infra.Bus;
using FKRM.Infra.Data.Context;
using FKRM.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace FKRM.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {


            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler,InMemoryBus>();

            //Domain Handler
            services.AddScoped<IRequestHandler<UpdateStaffCommand, Response<int>>, StaffCommandHandler>();
            services.AddScoped<IRequestHandler<DeleteStaffCommand, Response<int>>, StaffCommandHandler>();
            services.AddScoped<IRequestHandler<CreateStaffCommand, Response<int>>, StaffCommandHandler>();
            services.AddScoped<IRequestHandler<CreateGenderCommand,Response<int>>, GenderCommandHandler>();
            services.AddScoped<IRequestHandler<CreateMajorCommand, Response<int>>, MajorCommandHandler>();
            services.AddScoped<IRequestHandler<GetGenderByIdQuery, Response<Gender>>, GetGenderByIdQueryHandler>();

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
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IScheduleService, ScheduleService>();
            services.AddScoped<ISchoolService,SchoolService>();
            services.AddScoped<IStaffService, StaffService>();
            services.AddScoped<IUnitTypeService, UnitTypeService>();


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
            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IStaffRepository, StaffRepository>();
            services.AddScoped<IUnitTypeRepository, UnitTypeRepository>();
            services.AddScoped<SchoolDBContext>();


        }
    }
}
