
using COP2839_A2.Features.Weather;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        // Allow pages in /Features to be accessed without specifying the full path
        options.ViewLocationFormats.Add("/Features/{1}/{0}.cshtml");
        options.ViewLocationFormats.Add("/Features/Shared/{0}.cshtml");
    });

// Register VFRWxService; when IVFRWxService is requested, VFRWxService is returned
builder.Services.AddScoped<COP2839_A2.Interfaces.IVFRWxService, VFRWxService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

