using Microsoft.EntityFrameworkCore;
using RPBDIS_lab4.Models; // ���������, ��� ���� namespace ������������� ������ �������


var builder = WebApplication.CreateBuilder(args);

// ��������� ������� ��� ������ � ������������� � ���������������
builder.Services.AddControllersWithViews();

// ������������ �������� ���� ������ (�������� ������ ����������� �� ����)
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseMiddleware<DatabaseSeederMiddleware>();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
