using Newtonsoft.Json.Linq;
using NyanKaiheila.Net.Core.Models.Kaiheila.Event;

namespace NyanKaiheila.Net.Core.ISerives
{
    /// <summary>
    /// Bot 服务接口
    /// </summary>
    public interface IBotService
    {
        /// <summary>
        /// 启动 Bot
        /// </summary>
        void Run();
        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="arg">事件</param>
        void HandleEvent(KaiheilaBaseEvent<JObject> arg);
    }
}
