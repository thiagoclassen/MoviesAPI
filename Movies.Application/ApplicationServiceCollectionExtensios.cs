using Microsoft.Extensions.DependencyInjection;
using Movies.Application.Database;
using Movies.Application.Repositories;

namespace Movies.Application;
public static class ApplicationServiceCollectionExtensios
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddSingleton<IMovieRepository, MovieRepository>();
        return services;
    }

    public static IServiceCollection AddDatabase(this IServiceCollection services, string connectionString)
    {
        services.AddTransient<IDbConnectionFactory>(_ => new NpgsqlconnectionFactory(connectionString));
        services.AddSingleton<DbInitializer>();
        return services;
    }
}
