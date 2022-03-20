using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra
{
    /// <summary>
    /// 开黑啊视频消息事件扩展
    /// </summary>
    public class KaiheilaViedoMessageExtra : KaiheilaExtraBase
    {
        /// <summary>
        /// 事件扩展类型
        /// </summary>
        [JsonProperty("type")]
        public new KaiheilaEventType Type { get; set; } = KaiheilaEventType.ViedoMessage;

        /// <summary>
        /// 作用不明: code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 视频附件
        /// </summary>
        [JsonProperty("attachments")]
        public KaiheilaAttachment Attachments { get; set; }
    }
}
