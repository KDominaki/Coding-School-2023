using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IEntityRepo<Car>, CarRepo>();
builder.Services.AddScoped<IEntityRepo<Customer>, CustomerRepo>();
builder.Services.AddScoped<IEntityRepo<Engineer>, EngineerRepo>();
builder.Services.AddScoped<IEntityRepo<Manager>, ManagerRepo>();
builder.Services.AddScoped<IEntityRepo<ServiceTask>, ServiceTaskRepo>();
builder.Services.AddScoped<IEntityRepo<Transaction>, TransactionRepo>();
builder.Services.AddScoped<IEntityRepo<TransactionLine>, TransactionLineRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) {
    app.UseWebAssemblyDebugging();
} else {
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
