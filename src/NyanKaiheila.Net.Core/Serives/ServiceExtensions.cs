using Microsoft.Extensions.DependencyInjection;
using NyanKaiheila.Net.Core.ISerives;

namespace NyanKaiheila.Net.Core.Serives
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddBot(this IServiceCollection services)
        {
            services.AddSingleton<IBotService, BotService>();
            services.AddSingleton<ICommandService, CommandService>();
            services.AddSingleton<IEventHandleService, EventHandleService>();

            return services;
        }
    }
}
