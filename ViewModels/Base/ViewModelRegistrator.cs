using Microsoft.Extensions.DependencyInjection;

namespace Life_The_Game.ViewModels.Base;

internal static class ViewModelRegistrator
{
    public static IServiceCollection AddViewModels(this IServiceCollection services) => services
        .AddSingleton<MainWindowViewModel>()
        .AddSingleton<GameFieldViewModel>();

}
