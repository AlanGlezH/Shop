using Shop.User.Application.SearchAll;


namespace Shop.API.Extension.DependencyInjection;
public static class Application
{
    internal static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<UserSearcher, UserSearcher>();

        return services;
    }
}