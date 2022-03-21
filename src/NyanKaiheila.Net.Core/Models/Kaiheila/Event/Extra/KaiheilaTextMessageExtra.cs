using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra
{
    /// <summary>
    /// 开黑啦文字消息事件扩展
    /// </summary>
    [KaiheilaMessage(KaiheilaEventType.TextMessage)]
    public class KaiheilaTextMessageExtra : KaiheilaExtraBase
    {
        /// <summary>
        /// 事件扩展类型
        /// </summary>
        [JsonProperty("type")]
        public new KaiheilaEventType Type { get; set; } = KaiheilaEventType.TextMessage;

        /// <summary>
        /// 频道名称
        /// </summary>
        [JsonProperty("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 提及的用户
        /// </summary>
        [JsonProperty("mention")]
        public string[] Mentions { get; set; }

        /// <summary>
        /// 提及所有人
        /// </summary>
        [JsonProperty("mention_all")]
        public bool MentionAll { get; set; }

        /// <summary>
        /// 提及的角色
        /// </summary>
        [JsonProperty("mention_roles")]
        public string[] MentionRoles { get; set; }

        /// <summary>
        /// 提及在线用户
        /// </summary>
        [JsonProperty("mention_here")]
        public bool MentionHere { get; set; }
    }
}
