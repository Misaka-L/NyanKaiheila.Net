namespace NyanKaiheila.Net.Core.Serives
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
