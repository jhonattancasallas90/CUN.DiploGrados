using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CUN.DiploGrados.Application.Interface;
using CUN.DiploGrados.Application.Main;
using CUN.DiploGrados.Domain.Core;
using CUN.DiploGrados.Domain.Interface;
using CUN.DiploGrados.Infrastructure.Data;
using CUN.DiploGrados.Infrastructure.Interface;
using CUN.DiploGrados.Infrastructure.Repository;
using CUN.DiploGrados.Transversal.Common;
using CUN.DiploGrados.Transversal.Logging;

namespace CUN.DiploGrados.Services.WebApi.Modules.Injection
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConfiguration>(configuration);
            services.AddSingleton<DapperContext>();
            services.AddScoped<IStudentsApplication, StudentsApplication>();
            services.AddScoped<IStudentsRepository, StudentsRepository>();
            services.AddScoped<IStudentsDomain, StudentsDomain>();
            services.AddScoped<IUsersApplication, UsersApplication>();
            services.AddScoped<IUsersDomain, UsersDomain>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
