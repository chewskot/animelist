using C2.Data;  // Nezapomeò upravit podle názvu tvého namespace

var builder = WebApplication.CreateBuilder(args);

// Pøidání LiteDbContext jako singleton služby
builder.Services.AddSingleton<LiteDbContext>();

// Pøidání služeb pro MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Konfigurace pipeline pro HTTP požadavky
if (!app.Environment.IsDevelopment())
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
