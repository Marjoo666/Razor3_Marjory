using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RutasPracticaRodri.Data;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Services.AddDbContext<RutasPracticaRodriContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RutasPracticaRodriContext") ?? throw new InvalidOperationException("Connection string 'RutasPracticaRodriContext' not found.")));

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {

        context.Response.Redirect("/Empleados/Index1");
        return;
    }
    await next();
});


app.MapRazorPages();

app.Run();
