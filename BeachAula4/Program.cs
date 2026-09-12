using BeachAula4.Data;
using BeachAula4.Dtos;
using BeachAula4.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();
app.UseHttpsRedirection();

app.MapPost("/api/quadras", (Quadra quadra) =>
{

    using var db = new AppDbContext();

    db.Quadras.Add(quadra);
    db.SaveChanges();

    return Results.Created("/api/quadras/" + quadra.Id, quadra);
});

app.MapGet("/api/quadras", () =>
{
    using var db = new AppDbContext();

    return db.Quadras.ToList();
});

app.MapPost("/api/reservas", (CriarReservaDto dto) =>
{
    Reserva reserva = new Reserva(dto.ClienteId, dto.QuadraId, dto.Inicio, dto.Fim);
    Console.WriteLine(reserva.Valor);
});

// Configure the HTTP request pipeline.

app.Run();

