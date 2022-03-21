﻿using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NyanKaiheila.Net.Core.Models.Kaiheila.Event;

namespace NyanKaiheila.Net.Core.ISerives
{
    /// <summary>
    /// Bot 服务
    /// </summary>
    public class BotService : IBotService
    {
        private ILogger<BotService> _logger;
        private ICommandService _commandService;
        private IEventHandleService _eventHandleService;

        public BotService(ILogger<BotService> logger, ICommandService commandService, IEventHandleService eventHandleService)
        {
            _logger = logger;
            _commandService = commandService;
            _eventHandleService = eventHandleService;
        }

        public async void Run()
        {
            _logger.LogInformation("~~~");

            await _eventHandleService.Load();
            await _commandService.Load();
        }

        public void HandleEvent(KaiheilaBaseEvent<JObject> arg)
        {
            _logger.LogInformation(JsonConvert.SerializeObject(arg, Formatting.Indented));
            _eventHandleService.HadnleEvent(arg);
        }
    }
}