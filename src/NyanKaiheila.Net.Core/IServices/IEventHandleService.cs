using Newtonsoft.Json.Linq;
using NyanKaiheila.Net.Core.Models.Kaiheila.Event;

namespace NyanKaiheila.Net.Core.IServices
{
    public interface IEventHandleService
    {
        Task Load();
        Task HadnleEvent(KaiheilaBaseEvent<JObject> arg);
    }
}
