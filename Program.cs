using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDb")));
var app = builder.Build();

app.MapGet("/motos", async (AppDbContext db) => await db.Motos.ToListAsync());
app.MapGet("/moto/{id}", async (AppDbContext db, string id) =>
{
    var moto = await db.Motos.FindAsync(id);
    return moto is not null ? Results.Ok(moto) : Results.NotFound();
});
//Get com Query Params
app.MapGet("/moto", async (AppDbContext db, string? placa, string? tag, string? cliente) =>
{
    var query = db.Motos.AsQueryable();

    if (!string.IsNullOrEmpty(placa))
        query = query.Where(m => m.placa.Contains(placa));
    if (!string.IsNullOrEmpty(tag))
        query = query.Where(m => m.tag.Contains(tag));
    if (!string.IsNullOrEmpty(cliente))
        query = query.Where(m => m.cliente.Contains(cliente));

    return await query.ToListAsync();
});
app.MapPost("/moto", async (AppDbContext db, Moto moto) =>
{
    db.Motos.Add(moto);
    await db.SaveChangesAsync();
    return Results.Created($"/moto/{moto.id}", moto);
});
app.MapPut("/moto/{id}", async (AppDbContext db, string id, Moto updatedMoto) =>
{
    var moto = await db.Motos.FindAsync(id);
    if (moto is null) return Results.NotFound();

    moto.placa = updatedMoto.placa;
    moto.tag = updatedMoto.tag;
    moto.cliente = updatedMoto.cliente;

    await db.SaveChangesAsync();
    return Results.NoContent();
});
app.MapDelete("/moto/{id}", async (AppDbContext db, string id) =>
{
    var moto = await db.Motos.FindAsync(id);
    if (moto is null) return Results.NotFound();

    db.Motos.Remove(moto);
    await db.SaveChangesAsync();
    return Results.NoContent();
});
app.Run();
