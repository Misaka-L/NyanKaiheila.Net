using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Models.Kaiheila.Event;

namespace NyanKaiheila.Net.WebHook.Models
{
    /// <summary>
    /// 开黑啦 Challenge 事件
    /// </summary>
    public class KaiheilaChallengeEvent : KaiheilaBaseEvent
    {
        /// <summary>
        /// Challenge 值
        /// </summary>
        [JsonProperty("challenge")]
        public string Challenge { get; set; }

        /// <summary>
        /// VerifyToken
        /// </summary>
        [JsonProperty("verify_token")]
        public string VerifyToken { get; set; }
    }
}
