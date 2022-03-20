using Newtonsoft.Json.Linq;
using NyanKaiheila.Net.Core.Models.Kaiheila.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyanKaiheila.Net.Core.Serives
{
    /// <summary>
    /// Bot 服务接口
    /// </summary>
    public interface IBotService
    {
        void HandleEvent(KaiheilaBaseEvent<JObject> arg);
    }
}
