using Microsoft.Extensions.DependencyInjection;

namespace Life_The_Game.ViewModels.Base;

internal class ViewModelLocator
{
    public MainWindowViewModel MainWindowModel => 
        App.Services.GetRequiredService<MainWindowViewModel>();
}
