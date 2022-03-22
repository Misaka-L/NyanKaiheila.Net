using Microsoft.Extensions.Logging;
using NyanKaiheila.Net.Core.IServices;
using NyanKaiheila.Net.Core.Models;

namespace NyanKaiheila.Net.Core.Serives
{
    public class PluginsService : IPluginsService
    {
        private ILogger<PluginsService> _logger;
        private Dictionary<string, NyanKaiheilaPlugin> plugins = new Dictionary<string, NyanKaiheilaPlugin>();

        public PluginsService(ILogger<PluginsService> logger)
        {
            _logger = logger;
        }

        public Task GetPlugins()
        {
            throw new NotImplementedException();
        }

        public async Task Load()
        {
            await Task.Run(() =>
            {
                _logger.LogInformation("开始加载插件");
                // 没写
                _logger.LogInformation("加载完成");
            });
        }
    }
}
