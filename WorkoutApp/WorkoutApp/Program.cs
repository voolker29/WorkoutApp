using BusinessLayer;
using BusinessLayerInterfaces;
using DALEF;
using DALEF.Repositories;
using DALInterfaces.Models;
using DALInterfaces.Repositories;
using WorkoutApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// AddAuthentication
builder.Services
    .AddAuthentication("WebAuth")
    .AddCookie("WebAuth",
        option =>
        {
            option.LoginPath = "/Auth/Login";
        });

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IUserService, UserService>();


builder.Services.AddHttpContextAccessor();

//link database 
var dbContextResolver = new StartUp();
dbContextResolver.RegisterDbContext(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
