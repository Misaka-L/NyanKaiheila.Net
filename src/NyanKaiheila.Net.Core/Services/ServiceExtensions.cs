using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NyanKaiheila.Net.Core.IServices;
using NyanKaiheila.Net.Core.Models;
using NyanKaiheila.Net.Core.Serives;

namespace NyanKaiheila.Net.Core.Services
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBot(this IServiceCollection services)
        {
            services.AddSingleton<IBotService, BotService>();
            services.AddSingleton<ICommandService, CommandService>();
            services.AddSingleton<IEventHandleService, EventHandleService>();
            services.AddSingleton<IPluginsService, PluginsService>();

            IConfigurationRoot root = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            services.AddOptions();
            services.Configure<BotOptions>(root.GetSection("BotOptions"));

            return services;
        }
    }
}