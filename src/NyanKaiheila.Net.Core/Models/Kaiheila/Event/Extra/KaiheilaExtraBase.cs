using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event.Extra
{
    /// <summary>
    /// 基本事件扩展
    /// </summary>
    public class KaiheilaExtraBase
    {
        /// <summary>
        /// 事件扩展类型
        /// </summary>
        [JsonProperty("type")]
        public KaiheilaEventType Type { get; set; }

        /// <summary>
        /// 服务器 Id
        /// </summary>
        [JsonProperty("guild_id")]
        public string GuildId { get; set; }

        /// <summary>
        /// 发送者
        /// </summary>
        [JsonProperty("author")]
        public KaiheilaUser Author { get; set; }
    }
}
