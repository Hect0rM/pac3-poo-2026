using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOpenApi();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();//es un middle ware si se usa USE, cuando se hace una peticion en un momento se va a ejecutar ese middle ware para que sea lo principal que revice

app.UseAuthorization();// para proteger la info

app.MapControllers();//usa los controllers 

app.Run();


