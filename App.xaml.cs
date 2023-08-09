using Life_The_Game.Services.Base;
using Life_The_Game.ViewModels.Base;
using Life_The_Game.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace Life_The_Game;

public partial class App : Application
{
    private static IHost? host;

    public static IHost? Host => host 
        ??= Bootstrapper
        .CreateHostBuilder(Environment.GetCommandLineArgs())
        .Build();

    public static IServiceProvider Services => Host!.Services;

    internal static void ConfigureServices(HostBuilderContext host,
        IServiceCollection services) =>
        services.AddServices()
        .AddViewModels()
        //.AddDatabase(host.Configuration.GetSection("Database"))
    ;

    protected override async void OnStartup(StartupEventArgs e)
    {
        await Host!.StartAsync();

        var startupForm = 
            Host.Services.GetRequiredService<MainWindow>();

        startupForm.Show();

        base.OnStartup(e);
    }

    protected override async void OnExit(ExitEventArgs e)
    {

        base.OnExit(e);

        using (Host)  await Host!
                .StopAsync()
                .ConfigureAwait(false);
    }
}
