using Healthcare.Data;
using Healthcare.Domain.Patients;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Healthcare.IoC
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddDependency(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddScoped<IPatientRepository, PatientRepository>();
            service.AddDbContext<AppDbContext>(options =>{
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            return service;
        }
    }
}
