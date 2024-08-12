using BAL.Interfaces;
using BAL.Repositories;

public static class ServiceRegistrationExtensions
{
    public static void RegisterServices(this IServiceCollection services)
    {
        // Register repositories and services from BAL
        services.AddScoped<ISettingsCompanyGroupRepository, SettingsCompanyGroupRepository>();
        services.AddScoped<ISettingsCompanyRepository, SettingsCompanyRepository>();
        services.AddScoped<ISettingsLocationRepository, SettingsLocationRepository>();
        services.AddScoped<ISettingsCountryRepository, SettingsCountryRepository>();
        services.AddScoped<IExceptionLogger, ExceptionLogger>();
        // Register other repositories and services as needed
        // Example:
        // services.AddTransient<IExampleService, ExampleService>();
        // services.AddSingleton<ISingletonService, SingletonService>();
    }
}