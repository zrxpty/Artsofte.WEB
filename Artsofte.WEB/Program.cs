using Artsofte.BLL.Interfaces;
using Artsofte.BLL.Services;
using Artsofte.DAL;
using Artsofte.DAL.Interface;
using Artsofte.DAL.Repositories;
using Artsofte.WEB.AutoMapperProfiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ManagerDBContextConnection") ?? throw new InvalidOperationException("Connection string 'ManagerDBContextConnection' not found.");
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionString);
    options.EnableSensitiveDataLogging();
});

builder.Services.AddAutoMapper(typeof(EmployeeProfile));
builder.Services.AddAutoMapper(typeof(ProgrammingLanguageProfile));
builder.Services.AddAutoMapper(typeof(DepatamentProfile));

builder.Services.AddScoped<IUnitOfWork, EFUnitOfWork>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IProgrammingLanguageService, ProgrammingLanguageService>();
builder.Services.AddScoped<IDepartamentService, DepartamentService>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.Run();
