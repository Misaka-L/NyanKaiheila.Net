using NyanKaiheila.Net.Core.ISerives;
using NyanKaiheila.Net.Core.Serives;

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