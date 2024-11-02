using C2.Data;  // Nezapome� upravit podle n�zvu tv�ho namespace

var builder = WebApplication.CreateBuilder(args);

// P�id�n� LiteDbContext jako singleton slu�by
builder.Services.AddSingleton<LiteDbContext>();

// P�id�n� slu�eb pro MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Konfigurace pipeline pro HTTP po�adavky
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
