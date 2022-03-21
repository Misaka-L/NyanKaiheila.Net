using NyanKaiheila.Net.Core.ISerives;

namespace NyanKaiheila.Net.Core.Serives
{
    public class CommandService : ICommandService
    {
        public Task Load()
        {
            return Task.CompletedTask;
        }
    }
}
