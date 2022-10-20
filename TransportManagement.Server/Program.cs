using TransportManagement.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Добавление сервисов в контейнер.
builder.Services.AddControllers();
builder.Services.AddCustomServices(builder.Configuration);

var app = builder.Build();

// Настройка конвейера HTTP запросов.
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();