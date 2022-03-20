using Newtonsoft.Json;
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila
{
    /// <summary>
    /// 开黑啦用户
    /// </summary>
    public class KaiheilaUser
    {
        /// <summary>
        /// 用户 Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// 认证数字
        /// </summary>
        [JsonProperty("identify_num")]
        public string IdentifyNum { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        [JsonProperty("online")]
        public bool Online { get; set; }

        /// <summary>
        /// 头像 Url
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// Vip 头像 Url
        /// </summary>
        [JsonProperty("vip_avatar")]
        public string VipAvatar { get; set; }

        /// <summary>
        /// 是否为 Bot
        /// </summary>
        [JsonProperty("bot")]
        public bool Bot { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        [JsonProperty("status")]
        public KaiheilaUserStatus Status { get; set; }

        /// <summary>
        /// 是否验证手机
        /// </summary>
        [JsonProperty("mobile_verified")]
        public bool MobileVerified { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 用户在当前服务器角色列表
        /// </summary>
        [JsonProperty("roles")]
        public int[] roles { get; set; }
    }
}
