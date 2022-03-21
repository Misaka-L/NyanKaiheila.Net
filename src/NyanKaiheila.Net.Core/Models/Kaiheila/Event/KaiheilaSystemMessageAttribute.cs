
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Models.Kaiheila.Event
{
    public class KaiheilaSystemMessageAttribute : Attribute
    {
        public KaiheilaSystemMessageType Type { get; set; }

        public KaiheilaSystemMessageAttribute(KaiheilaSystemMessageType type)
        {
            Type = type;
        }
    }
}