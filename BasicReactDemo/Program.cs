using BasicReactDemo.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("mockdata.json");

// Add services to the container.

builder.Services.AddOptions();
builder.Services.Configure<List<LabRecord>>(
    builder.Configuration.GetSection("LabRecords"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "LabRecords",
    pattern: "{controller=LabRecords}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller}/{action=Index}/{id?}");


app.MapFallbackToFile("index.html");

app.Run();
