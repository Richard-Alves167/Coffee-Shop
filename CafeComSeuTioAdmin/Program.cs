using CafeComSeuTioAdmin.Data;
using CafeteriaKwai.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using CafeteriaKwai.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<CafeContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("WiredBrain")));

//builder.Services.AddDbContext<IdentidadeContext>(options =>
//   options.UseSqlServer(builder.Configuration.GetConnectionString("WiredBrain")));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("WiredBrain")));

builder.Services.AddDefaultIdentity<ApplicationUser>(
    options => options.SignIn.RequireConfirmedAccount = true)
     .AddRoles<IdentityRole>()
     .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.ConfigureApplicationCookie(options => {
    options.Cookie.Name = ".Cafecom.Authentication"; ;
    options.ExpireTimeSpan = TimeSpan.FromDays(7); // ← tempo de vida total do cookie
    options.SlidingExpiration = true; // ← renova a expiração a cada requisição
    options.LoginPath = "/Identity/Account/Login"; // ← opcional, se quiser definir uma página de login customizada
});


//builder.Services.AddDefaultIdentity<
//>(options =>
//    options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<CafeContext>();

builder.Services.AddScoped<IProductRepository, ProductRepositoryEF>();
builder.Services.AddScoped<IIdentityRepository, IdentityRepositoryEF>();

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

app.Run();