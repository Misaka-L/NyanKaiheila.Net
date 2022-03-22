using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using NyanKaiheila.Net.Core.Attributes;
using NyanKaiheila.Net.Core.Enums;
using NyanKaiheila.Net.Core.IServices;
using NyanKaiheila.Net.Core.Models.Kaiheila.Event;
using System.Reflection;

namespace NyanKaiheila.Net.Core.Serives
{
    public class EventHandleService : IEventHandleService
    {
        private Dictionary<KaiheilaEventType, Type> kaiheilaMessageExtra = new Dictionary<KaiheilaEventType, Type>();
        private Dictionary<KaiheilaSystemMessageType, Type> kaiheilaSystemMessageExtra = new Dictionary<KaiheilaSystemMessageType, Type>();

        private ILogger<EventHandleService> _logger;

        public EventHandleService(ILogger<EventHandleService> logger)
        {
            _logger = logger;
        }

        public async Task Load()
        {
            _logger.LogInformation("开始初始化事件路由: 搜索消息类型");

            await Task.Run(() =>
            {
                var assembly = Assembly.GetExecutingAssembly();
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    foreach (var attribute in type.GetCustomAttributes(false))
                    {
                        if (attribute is KaiheilaMessageAttribute)
                        {
                            var messageAttribute = attribute as KaiheilaMessageAttribute;
                            kaiheilaMessageExtra.Add(messageAttribute.Type, type);
                            _logger.LogInformation("建立消息类型映射: {0} - {1}", messageAttribute.Type.ToString(), type.Name);
                            break;
                        }

                        if (attribute is KaiheilaSystemMessageAttribute)
                        {
                            var systemAttribute = attribute as KaiheilaSystemMessageAttribute;
                            kaiheilaSystemMessageExtra.Add(systemAttribute.Type, type);
                            _logger.LogInformation("建立系统消息类型映射: {0} - {1}", systemAttribute.Type.ToString(), type.Name);
                            break;
                        }
                    }
                }
            });

            _logger.LogInformation("事件路由初始化完成");
        }

        public Task HadnleEvent(KaiheilaBaseEvent<JObject> arg)
        {
            switch (arg.Type)
            {
                case KaiheilaEventType.System:

                    break;
                default:
                    arg.Extra.ToObject(kaiheilaMessageExtra[arg.Type]);
                    break;
            }

            return Task.CompletedTask;
        }
    }
}