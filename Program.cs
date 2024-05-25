using Integrador.Dal;
using Integrador.Dal.Data;
using Integrador.Dal.Repository;
using Integrador.Dal.Repository.Interface;
using Integrador.Service;
using Integrador.Service.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//--------------Services------------------------ | configuracion DB
builder.Services.AddDbContext<DataContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStringEF")));

//-------------------------------Inyecciones-----| los repositorios creados

builder.Services.AddScoped<IViajeRepositorio, ViajeRepositorio>();
builder.Services.AddScoped<ICamionRepository, CamionRepositorio>();

/*agrega el unitOFWork asi si algo falla no se guerda nada*/
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(x=> new UnitOfWork(x.GetRequiredService<DataContext>(),
    x.GetRequiredService<ICamionRepository>(),
    x.GetRequiredService<IViajeRepositorio>()));

builder.Services.AddScoped < IViajeService, ViajeService >();

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
