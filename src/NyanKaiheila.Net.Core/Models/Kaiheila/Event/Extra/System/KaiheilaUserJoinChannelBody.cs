using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Attributes;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra.System
{
    /// <summary>
    /// 开黑啦用户加入语音频道事件内容
    /// </summary>
    [KaiheilaSystemMessage(KaiheilaSystemMessageType.joined_channel)]
    public class KaiheilaUserJoinChannelBody
    {
        /// <summary>
        /// 用户 Id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
        /// <summary>
        /// 频道 Id
        /// </summary>
        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }
        /// <summary>
        /// 加入时间
        /// </summary>
        [JsonProperty("joined_at")]
        public long JoinedAt { get; set; }
    }
}
