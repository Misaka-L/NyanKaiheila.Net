using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event
{
    /// <summary>
    /// 信令
    /// </summary>
    /// <typeparam name="T">信令事件数据类型</typeparam>
    public class KaiheilaSignaling<T>
    {
        /// <summary>
        /// 信令类型
        /// </summary>
        [JsonProperty("s")]
        public KaiheilaSignalingType Type { get; set; }

        /// <summary>
        /// 信令数据
        /// </summary>
        [JsonProperty("d")]
        public T Data { get; set; }

        /// <summary>
        /// 信令编号
        /// </summary>
        [JsonProperty("sn")]
        public long Sn { get; set; }
    }
}
