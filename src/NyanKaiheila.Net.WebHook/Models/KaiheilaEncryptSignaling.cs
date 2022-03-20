using Newtonsoft.Json;

namespace NyanKaiheila.Net.WebHook.Models
{
    /// <summary>
    /// 开黑啦加密信令
    /// </summary>
    public class KaiheilaEncryptSignaling
    {
        /// <summary>
        /// 密文
        /// </summary>
        [JsonProperty("encrypt")]
        public string Encrypt { get; set; }
    }
}
