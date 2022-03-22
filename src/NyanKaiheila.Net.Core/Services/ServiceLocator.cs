namespace NyanKaiheila.Net.Core.Services
{
    /// <summary>
    /// 服务获取
    /// </summary>
    public static class ServiceLocator
    {
        /// <summary>
        /// IServiceProvider
        /// </summary>
        public static IServiceProvider Instance { get; set; }
    }
}
