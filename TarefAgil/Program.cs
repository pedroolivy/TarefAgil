using Microsoft.EntityFrameworkCore;
using TarefAgil.Dominio.Interfaces;
using TarefAgil.Infa.Dados;
using TarefAgil.Infa.Repositorios;
using TarefAgil.Infa.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IServicoTarefas, ServicoTarefas>();
builder.Services.AddScoped<IServicoUsuario, ServicoUsuario>();

builder.Services.AddScoped<IRepositorioTarefas, TarefasRepositorio>();
builder.Services.AddScoped<IRepositorioUsuario, UsuarioRepositorio>();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
