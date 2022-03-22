using Microsoft.Extensions.DependencyInjection;

namespace NyanKaiheila.Net.Core.Models
{
    public class NyanKaiheilaPlugin
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual IServiceCollection AddServices(IServiceCollection services)
        {
            return services;
        }

        public virtual void LoadPlugin(IServiceProvider serviceProvider)
        {

        }
    }
}