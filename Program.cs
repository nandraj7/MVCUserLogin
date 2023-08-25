using Microsoft.EntityFrameworkCore;
using MVCUserLogin.BAL;
using MVCUserLogin.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ILoginService, LoginService>();

builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddDbContext<MvcloginUserContext>(option => option.UseSqlServer(
    builder.Configuration.GetConnectionString("CCDB")
    ));

builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
