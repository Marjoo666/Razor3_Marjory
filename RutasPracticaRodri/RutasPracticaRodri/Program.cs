using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Razorr3_10266464.Data;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddRazorPages();
builder.Services.AddDbContext<Razorr3_10266464Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Razorr3_10266464Context") ?? throw new InvalidOperationException("Connection string 'Razorr3_10266464Context' not found.")));

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
