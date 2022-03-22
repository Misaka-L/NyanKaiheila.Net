
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class KaiheilaSystemMessageAttribute : Attribute
    {
        public KaiheilaSystemMessageType Type { get; set; }

        public KaiheilaSystemMessageAttribute(KaiheilaSystemMessageType type)
        {
            Type = type;
        }
    }
}