using TransportManagement.Server.Extensions;

var builder = WebApplication.CreateBuilder(args);

// ���������� �������� � ���������.
builder.Services.AddControllers();
builder.Services.AddCustomServices(builder.Configuration);

var app = builder.Build();

// ��������� ��������� HTTP ��������.
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();