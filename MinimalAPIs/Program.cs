using MinimalAPIs.Models;
using MinimalAPIs.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ICarService, CarService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapGet("/api/cars",  (ICarService service) =>
{
    return Results.Ok(service.GetAll());
});

app.MapGet("/api/car/{id:int}", (int id, ICarService service) =>
{
    var car = service.Get(id);
    return car;
});

app.MapMethods("/api/save", new[] {"POST", "PUT"}, (Car car, ICarService service) =>
{
    service.Save(car);
    return Results.Ok();
});

app.Run();
