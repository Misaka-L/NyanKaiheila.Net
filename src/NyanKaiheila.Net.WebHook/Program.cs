using NyanKaiheila.Net.Core.Serives;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<IBotService, BotService>();

var app = builder.Build();
app.UseAuthorization();
app.MapControllers();
app.Run();