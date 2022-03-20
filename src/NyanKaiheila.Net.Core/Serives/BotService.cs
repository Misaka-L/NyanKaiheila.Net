using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NyanKaiheila.Net.Core.Models.Kaiheila.Event;
using NyanKaiheila.Net.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanKaiheila.Net.Core.Serives
{
    /// <summary>
    /// Bot 服务
    /// </summary>
    public class BotService : IBotService
    {
        private ILogger<BotService> _logger;

        public BotService(ILogger<BotService> logger)
        {
            _logger = logger;
        }

        public void HandleEvent(KaiheilaBaseEvent<JObject> arg)
        {
            _logger.LogInformation(
                JsonConvert.SerializeObject(arg, Formatting.Indented)
                );
        }
    }
}