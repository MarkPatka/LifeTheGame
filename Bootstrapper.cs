using Microsoft.Extensions.Hosting;
using System;

namespace Life_The_Game
{
    internal static class Bootstrapper
    {
        [STAThread]
        public static void Initialize()
        {
            var App = new App();
            App.InitializeComponent();
            App.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => 
            Host.CreateDefaultBuilder(args)
            .ConfigureServices(App.ConfigureServices);
    }
}
