using Shop.User.Domain;
using Shop.User.Application.SearchAll;
using Shop.User.Infrastructure;



namespace Shop.API.Extension.DependencyInjection;
public static class Infrastructure
{
    internal static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {

        services.AddTransient<UserRepository, InMemoryUserRepository>();


        return services;
    }
}