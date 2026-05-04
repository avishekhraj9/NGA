using ReportingSystem.Interfaces;
using ReportingSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add Razor Pages
builder.Services.AddRazorPages();

// Register dependencies (DIP)
builder.Services.AddTransient<IReportGenerator, ReportGenerator>();
builder.Services.AddTransient<IReportSaver, ReportSaver>();

// Change this to ExcelFormatter to test OCP
builder.Services.AddTransient<IReportFormatter, PdfFormatter>();

builder.Services.AddTransient<ReportService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();

app.Run();