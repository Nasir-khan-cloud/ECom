using BeratenECommerceDataAccess.DbModel;
using BeratenECommerceDataAccess.Ifaces;
using BeratenECommerceDataAccess.Managers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddScoped<IItem, ItemManager>();

string dbCon = builder.Configuration.GetValue<string>("DbConnections:Local");

builder.Services.AddDbContext<BeratenECommerceModel>(op =>
        op.UseSqlServer(dbCon, x => x.MigrationsAssembly("BeratenECommerceDataAccess")
        .CommandTimeout(90).MinBatchSize(1).MaxBatchSize(40).UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery)));

//builder.Services.AddBlazoredLocalStorage();
//builder.Services.AddBlazoredSessionStorage();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
