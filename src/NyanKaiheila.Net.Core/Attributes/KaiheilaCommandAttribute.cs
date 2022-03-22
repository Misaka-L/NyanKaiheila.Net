using NyanKaiheila.Net.Core.Enums;

namespace NyanKaiheila.Net.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class KaiheilaCommandAttribute : Attribute
    {
        public string Command { get; set; }
        public KaiheilaEventType Type { get; set; }
        public string Description { get; set; }

        public KaiheilaCommandAttribute(string command, KaiheilaEventType type, string description)
        {
            Command = command;
            Type = type;
            Description = description;
        }
    }
}
