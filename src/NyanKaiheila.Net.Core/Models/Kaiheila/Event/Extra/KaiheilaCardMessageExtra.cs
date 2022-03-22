using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Attributes;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra
{
    /// <summary>
    /// 开黑啦卡片消息事件扩展
    /// </summary>
    [KaiheilaMessage(KaiheilaEventType.CardMessage)]
    public class KaiheilaCardMessageExtra : KaiheilaTextMessageExtra
    {
        /// <summary>
        /// 事件扩展类型
        /// </summary>
        [JsonProperty("type")]
        public new KaiheilaEventType Type { get; set; } = KaiheilaEventType.CardMessage;
    }
}
