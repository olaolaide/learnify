using Api.ErrorResponse;
using Api.Helpers;
using Entity.Interfaces;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions;

public static class InfrastructureServiceExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration config)
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

        // Configure model validation error response
        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.InvalidModelStateResponseFactory = actionContext =>
            {
                var errors = actionContext.ModelState.Where(e => e.Value.Errors.Count > 0)
                    .SelectMany(x => x.Value.Errors)
                    .Select(x => x.ErrorMessage).ToArray();
                var errorResponse = new ApiValidationErrorResponse
                {
                    Errors = errors
                };
                return new BadRequestObjectResult(errorResponse);
            };
        });

        // Add repositories
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        // Add AutoMapper profiles
        services.AddAutoMapper(typeof(MappingProfiles));

        return services;
    }
}