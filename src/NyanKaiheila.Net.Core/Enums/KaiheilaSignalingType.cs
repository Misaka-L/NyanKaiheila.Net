namespace NyanKaiheila.Net.Core.Enums
{
    public enum KaiheilaSignalingType
    {
        /// <summary>
        /// HELLO
        /// </summary>
        Hello = 1,
        /// <summary>
        /// EVENT
        /// </summary>
        Event = 0,
        /// <summary>
        /// PING
        /// </summary>
        Ping = 2,
        /// <summary>
        /// PONG
        /// </summary>
        Pong = 3,
        /// <summary>
        /// RESUME
        /// </summary>
        Resume = 4,
        /// <summary>
        /// RECONNECT
        /// </summary>
        Reconnect = 5
    }
}
