using Newtonsoft.Json;

namespace NyanKaiheila.Net.Core.Utils
{
    /// <summary>
    /// Json 工具
    /// </summary>
    public class JsonUtils
    {
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <typeparam name="T">反序列化对象类型</typeparam>
        /// <param name="json">Json</param>
        /// <returns>反序列化对象</returns>
        public static async Task<T> DeserializeObjectAsync<T>(string json) =>
            await Task.Run(() => JsonConvert.DeserializeObject<T>(json));

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="obj">序列化对象</param>
        /// <returns>Json</returns>
        public static async Task<string> SerializeObjectAsync(object obj) =>
            await Task.Run(() => JsonConvert.SerializeObject(obj));
    }
}
