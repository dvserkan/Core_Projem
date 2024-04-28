using DataAccessLayer.Concrete;
using EntityLayer.Concrate;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Razor.TagHelpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<WriterUser, WriterRole>().AddEntityFrameworkStores<Context>(); //Identity Register Ekleme Ýþlemleri Ýçin Yazýlan Attribute
builder.Services.AddDbContext<Context>(); //Identity Register Ekleme Ýþlemleri Ýçin Yazýlan Attribute

builder.Services.AddMvc(config =>
{
	var policy = new AuthorizationPolicyBuilder()
	.RequireAuthenticatedUser()
	.Build();
	config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();

builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.HttpOnly = true;
	options.ExpireTimeSpan = TimeSpan.FromMinutes(100); //AUT KALMA ZAMANI
	options.AccessDeniedPath = "/ErrorPage/Index/";
	options.LoginPath = "/Writer/Login/Index/";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/"); //Hata Sayfasý Yönlendirme.
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();


app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
	name: "areas",
	pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}");


app.Run();
