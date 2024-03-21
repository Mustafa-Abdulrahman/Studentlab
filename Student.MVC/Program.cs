using Microsoft.EntityFrameworkCore;
using Student.BL.AppCinfigure;
using Student.BL.Helpers;
using Student.BL.Managers.Student;
using Student.DAL.Data.Context;
using Student.DAL.Repo.Student;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("StudentDB");
builder.Services.AddDbContext<StudentContext>(option =>
{
    option.UseSqlServer(connectionString);
});
builder.Services.Configure<FileConfig>(
    builder.Configuration.GetSection(FileConfig.myDataValid));
builder.Services.AddScoped<IStudentRepo, StudentRepository>();
builder.Services.AddScoped<IStudentManager, StudentManager>();

builder.Services.AddSingleton<IUtilities, Utilities>();
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
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
