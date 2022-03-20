using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event
{
    /// <summary>
    /// 开黑啦基本事件
    /// </summary>
    public class KaiheilaBaseEvent
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("type")]
        public KaiheilaEventType Type { get; set; }

        /// <summary>
        /// 消息频道类型 GROUP 为频道消息
        /// </summary>
        [JsonProperty("channel_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public KaiheilaChannelType ChannelType { get; set; }

        /// <summary>
        /// 发送目的 Id
        /// </summary>
        [JsonProperty("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 发送者数据库
        /// </summary>
        [JsonProperty("author_id")]
        public string AuthorId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息 Id
        /// </summary>
        [JsonProperty("msg_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 消息时间
        /// </summary>
        [JsonProperty("msg_timestamp")]
        //[JsonConverter(typeof(UnixDateTimeConverter))]
        public long MessageTimestamp { get; set; }

        /// <summary>
        /// 随机串
        /// </summary>
        [JsonProperty("nonce")]
        public string Nonce { get; set; }
    }

    /// <summary>
    /// 开黑啦基本扩展事件
    /// </summary>
    public class KaiheilaBaseEvent<T> : KaiheilaBaseEvent
    {
        /// <summary>
        /// 消息扩展
        /// </summary>
        [JsonProperty("extra")]
        public T Extra { get; set; }
    }
}
