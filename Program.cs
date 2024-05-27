using Mfund.Service;
using MutualFund.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient<UserService>();
builder.Services.AddScoped<UserService>();

builder.Services.AddHttpClient<GTTService>();
builder .Services.AddScoped<GTTService>();

builder.Services.AddHttpClient<OrderService>();
builder.Services.AddScoped<OrderService>();

builder.Services.AddHttpClient<BrokerageCalculatorService>();
builder.Services.AddScoped<BrokerageCalculatorService>();

builder.Services.AddHttpClient<PortfolioService>();
builder.Services.AddScoped<PortfolioService>();

builder.Services.AddHttpClient<EDIsAPIsService>();
builder.Services.AddScoped<EDIsAPIsService>();

builder.Services.AddControllers();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
