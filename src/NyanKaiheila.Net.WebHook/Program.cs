using NyanKaiheila.Net.Core.IServices;
using NyanKaiheila.Net.Core.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddBot();

var app = builder.Build();
app.UseAuthorization();
app.MapControllers();
ServiceLocator.Instance = app.Services;

var bot = ServiceLocator.Instance.GetService<IBotService>();
bot.Run();
app.Run();