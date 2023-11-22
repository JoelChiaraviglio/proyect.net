using ProyectoFinal.Application;
using ProyectoFinal.Infraestructure;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["Database:Conexion"];

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.InstallApplication();
builder.Services.InstallRepositories(connectionString);

builder.Services.AddCors(x =>

    x.AddPolicy("Default", policy =>
    {
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    })

);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Default");

app.MapControllers();

app.Run();
