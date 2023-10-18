using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.MapGet("/tva", ([FromQuery] double prix, [FromQuery] String pays) =>
{
    return CalculerTVA(prix, pays);
})
.WithName("GetTVAPrice");

double CalculerTVA(double prix, String pays)
{
    double TVA_Percent = (pays == "BE") ? 1.21 : 1.20;
    return prix * TVA_Percent;
}
app.Run();
