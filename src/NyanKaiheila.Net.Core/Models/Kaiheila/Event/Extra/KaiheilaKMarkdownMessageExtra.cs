using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra
{
    /// <summary>
    /// 开黑啦 KMarkdown 事件消息扩展
    /// </summary>
    [KaiheilaMessage(KaiheilaEventType.KMarkdownMessage)]
    public class KaiheilaKMarkdownMessageExtra : KaiheilaTextMessageExtra
    {
        /// <summary>
        /// 事件扩展类型
        /// </summary>
        [JsonProperty("type")]
        public new KaiheilaEventType Type { get; set; } = KaiheilaEventType.KMarkdownMessage;

        /// <summary>
        /// KMarkdown 内容
        /// </summary>
        [JsonProperty("kmarkdown")]
        public KaiheilaKMarkdown KMarkdown { get; set; }
    }
}
