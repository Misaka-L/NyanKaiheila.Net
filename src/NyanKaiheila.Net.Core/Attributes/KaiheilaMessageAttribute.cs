
using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class KaiheilaMessageAttribute : Attribute
    {
        public KaiheilaEventType Type { get; set; }

        public KaiheilaMessageAttribute(KaiheilaEventType type)
        {
            Type = type;
        }
    }
}