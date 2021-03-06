using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Attributes;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra
{
    /// <summary>
    /// 开黑啦文件消息事件扩展
    /// </summary>
    [KaiheilaMessage(KaiheilaEventType.FileMessage)]
    public class KaiheilaFileMessageExtra : KaiheilaExtraBase
    {
        /// <summary>
        /// 事件扩展类型
        /// </summary>
        [JsonProperty("type")]
        public new KaiheilaEventType Type { get; set; } = KaiheilaEventType.FileMessage;

        /// <summary>
        /// 作用不明: code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 文件附件
        /// </summary>
        [JsonProperty("attachments")]
        public KaiheilaAttachment Attachments { get; set; }
    }
}
