using Life_The_Game.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Life_The_Game.Services.Base;

internal static class ServiceRegistrator
{
    public static IServiceCollection AddServices(this IServiceCollection services) => 
        services.AddSingleton<MainWindow>()
        ;

}
