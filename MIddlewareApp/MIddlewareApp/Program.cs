var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Error handling middleware
app.UseExceptionHandler("/error");

// Custom error endpoint
app.Map("/error", () =>
{
    return Results.Problem("An unexpected error occurred.");
});

// Test route (to generate error)
app.Map("/test", () =>
{
    throw new Exception("Test Exception");
});
app.UseDefaultFiles();
app.UseStaticFiles();


app.Run();