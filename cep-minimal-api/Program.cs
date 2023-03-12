using cep_minimal_api;
using cep_minimal_api.Providers.v1.ViaCep;
using cep_minimal_api.Providers.v1.ViaCep.Models;
using cep_minimal_api.Utils;
using System.Text.RegularExpressions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ResolveDependencies();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("GetCep/{cep}", async (
    ViaCepClient viaCepClient,
    string cep) =>
{
    cep = cep.RemoveSpecialCharacters();

    if (string.IsNullOrWhiteSpace(cep))
        return Results.BadRequest("Cep can't be empty or white space!");

    if(!Regex.IsMatch(cep, @"^\d{8}$"))
        return Results.BadRequest("Invalid Cep!");

    Address address = await viaCepClient.GetAddressByCep(cep);

    return !address.HasError ? Results.Ok(address) : Results.BadRequest("Invalid Cep!");
})
.WithName("GetCep")
.WithTags("Cep");

app.Run();