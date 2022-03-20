using Newtonsoft.Json;

namespace NyanKaiheila.Net.Core.Models.Kaiheila
{
    /// <summary>
    /// 开黑啦附件
    /// </summary>
    public class KaiheilaAttachment
    {
        /// <summary>
        /// 附件类型
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 附件名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件 Url
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 附件大小
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }
    }
}
