using MELIPARCIAL.Data; // Cambia esto si tu espacio de nombres es diferente
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agrega servicios al contenedor.
builder.Services.AddControllersWithViews();

// Configura el DbContext para usar PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configura la canalización de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
