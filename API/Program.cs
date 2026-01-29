using API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<MCOneServices>();
builder.Services.AddScoped<MCTwoServices>();
builder.Services.AddScoped<MCThreeServices>();
builder.Services.AddScoped<MCFourServices>();
builder.Services.AddScoped<MCFiveServices>();
builder.Services.AddScoped<MCSixServices>();
builder.Services.AddScoped<MCSevenServices>();
builder.Services.AddScoped<MCEightServices>();
builder.Services.AddScoped<MCNineServices>();
builder.Services.AddScoped<MCTenServices>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
