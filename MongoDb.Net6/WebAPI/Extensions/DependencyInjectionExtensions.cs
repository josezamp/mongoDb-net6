using Domain.Entities;
using Domain.Mappers;
using Domain.Services;
using Persistence.Repository;
using Shared.Extensions;

namespace WebAPI.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
            services.AddSingleton<MongoRepository<Book>>();
        }

        /// <summary>
        /// Add MongoDb settings to Service Collector.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddMongoDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDbSettings>(configuration.GetSection("ConnectionStrings"));
        }

        /// <summary>
        /// Add AutoMapper profiles.
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(x =>
            {
                x.AddProfile<MapperProfiles>();
            });
        }
    }
}
