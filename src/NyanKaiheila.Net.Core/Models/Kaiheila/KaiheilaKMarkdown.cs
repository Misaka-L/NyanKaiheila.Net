using Newtonsoft.Json;

namespace NyanKaiheila.Net.Core.Models.Kaiheila
{
    /// <summary>
    /// 开黑啦 KMarkdown 内容
    /// </summary>
    public class KaiheilaKMarkdown
    {
        /// <summary>
        /// KMarkdown 内容
        /// </summary>
        [JsonProperty("raw_content")]
        public string Content { get; set; }

        /// <summary>
        /// 提及部分
        /// </summary>
        [JsonProperty("mention_part")]
        public string[] MentionParts { get; set; }

        /// <summary>
        /// 提及角色
        /// </summary>
        [JsonProperty("mention_role_part")]
        public string[] MentionRolePart { get; set; }
    }
}
