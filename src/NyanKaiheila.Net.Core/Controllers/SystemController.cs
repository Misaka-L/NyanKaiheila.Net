using Microsoft.Extensions.Logging;
using NyanKaiheila.Net.Core.Attributes;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Commands
{
    public class SystemController : BaseKaiheilaController
    {
        private readonly ILogger _logger;

        public SystemController(ILogger<SystemController> logger)
        {
            _logger = logger;
        }

        [KaiheilaCommand("about", KaiheilaEventType.TextMessage, "关于")]
        public void About()
        {

        }
    }
}