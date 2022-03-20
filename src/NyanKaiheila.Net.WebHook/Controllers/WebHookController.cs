using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using NyanKaiheila.Net.Core.Enums;
using NyanKaiheila.Net.Core.Models.Kaiheila.Event;
using NyanKaiheila.Net.Core.Serives;
using NyanKaiheila.Net.Core.Utils;
using NyanKaiheila.Net.WebHook.Models;
using NyanKaiheila.Net.WebHook.Utils;

namespace NyanKaiheila.Net.WebHook.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WebHookController : ControllerBase
    {
        private readonly ILogger<WebHookController> _logger;
        private readonly IBotService _botService;

        private readonly string key = "YourEncryptKey";
        private readonly string verifyToken = "YourVerifyToken";

        public WebHookController(ILogger<WebHookController> logger, IBotService botService)
        {
            _logger = logger;
            _botService = botService;
        }

        [HttpPost]
        public async Task<IActionResult> Get()
        {
            var raw = await ZlibCompressUtil.DecompressString(Request.Body);

            var encryptJson = await JsonUtils.DeserializeObjectAsync<KaiheilaEncryptSignaling>(raw);
            var contentJson = await CryptUtil.Decrypt(encryptJson.Encrypt, key);

            var signaling = await JsonUtils.DeserializeObjectAsync<KaiheilaSignaling<JObject>>(contentJson);
            var baseEvent = signaling.Data.ToObject<KaiheilaChallengeEvent>();

            if (baseEvent.VerifyToken != verifyToken) throw new Exception("错误的 VerifyToken，请检查 VerifyToken 是否正确，网络是否被干扰");
            switch (baseEvent.ChannelType)
            {
                case KaiheilaChannelType.WEBHOOK_CHALLENGE:
                    return Content(await JsonUtils.SerializeObjectAsync(new
                    {
                        challenge = baseEvent.Challenge
                    }));
                default:
                    _botService.HandleEvent(signaling.Data.ToObject<KaiheilaBaseEvent<JObject>>());
                    return Ok();
            }
        }
    }
}
