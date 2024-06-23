using Api.Helpers;
using Entity.Interfaces;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration config)
    {
        // Add controllers service
        services.AddControllers();

        // Add Swagger services
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        // Configure the database context
        services.AddDbContext<StoreContext>(opt =>
            opt.UseSqlite(config.GetConnectionString("DefaultConnection")));

        // Configure CORS policy
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", policy =>
            {
                policy.AllowAnyMethod()
                    .AllowAnyHeader()
                    .WithOrigins("http://localhost:5173");
            });
        });
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddAutoMapper(typeof(MappingProfiles));
        return services;
    }
}