namespace NyanKaiheila.Net.Core.Enums
{
    /// <summary>
    /// 开黑啦事件类型
    /// </summary>
    public enum KaiheilaEventType
    {
        /// <summary>
        /// 系统消息
        /// </summary>
        System = 255,
        /// <summary>
        /// 文本消息
        /// </summary>
        TextMessage = 1,
        /// <summary>
        /// 图片消息
        /// </summary>
        ImageMessage = 2,
        /// <summary>
        /// 视频消息
        /// </summary>
        ViedoMessage = 3,
        /// <summary>
        /// 文件消息
        /// </summary>
        FileMessage = 4,
        /// <summary>
        /// 音频消息
        /// </summary>
        AudioMessage = 8,
        /// <summary>
        /// KMarkdown 消息
        /// </summary>
        KMarkdownMessage = 9,
        /// <summary>
        /// 卡片消息
        /// </summary>
        CardMessage = 10
    }
}
