using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra.System
{
    /// <summary>
    /// 开黑啦系统消息事件扩展
    /// </summary>
    public class KaiheilaSystemMessageExtraBase<T>
    {
        /// <summary>
        /// 系统消息类型
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public KaiheilaSystemMessageType Type { get; set; }

        /// <summary>
        /// 系统消息数据
        /// </summary>
        [JsonProperty("body")]
        public T Body { get; set; }
    }
}