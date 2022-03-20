using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra
{
    /// <summary>
    /// 开黑啦图片消息事件扩展
    /// </summary>
    public class KaiheilaImageMessageExtra : KaiheilaExtraBase
    {
        /// <summary>
        /// 事件扩展类型
        /// </summary>
        [JsonProperty("type")]
        public new KaiheilaEventType Type { get; set; } = KaiheilaEventType.ImageMessage;

        /// <summary>
        /// 作用不明: code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 图片附件
        /// </summary>
        [JsonProperty("attachments")]
        public KaiheilaAttachment Attachments { get; set; }
    }
}
