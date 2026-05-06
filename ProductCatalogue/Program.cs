using ProductCatalogue;
using Microsoft.Extensions.Http;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient<ProductCatalogue.ERPSync>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});

var app = builder.Build();

//Make swagger development only
//Add my own endpoints above app.MapSwagger();
app.MapSwagger();

app.UseSwagger();

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("v1/swagger.json", "My API V1");
});


/*if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
}
*/

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

