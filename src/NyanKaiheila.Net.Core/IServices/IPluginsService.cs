namespace NyanKaiheila.Net.Core.IServices
{
    public interface IPluginsService
    {
        Task Load();
        Task GetPlugins();
    }
}
