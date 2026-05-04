var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


// ✅ Middleware 1: Logging Requests & Responses
app.Use(async (context, next) =>
{
    Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

    await next(); // Pass to next middleware

    Console.WriteLine($"Response Status: {context.Response.StatusCode}");
});


// ✅ Middleware 2: Exception Handling
app.UseExceptionHandler("/error");

// Custom error endpoint
app.Map("/error", (HttpContext context) =>
{
    return Results.Content("Something went wrong! Custom Error Page");
});


// ✅ Middleware 3: Enforce HTTPS
app.UseHttpsRedirection();


// ✅ Middleware 4: Content Security Policy (CSP)
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy",
        "default-src 'self'; script-src 'self'; style-src 'self';");

    await next();
});


// ✅ Middleware 5: Serve Static Files
app.UseStaticFiles();


// Default route
app.MapGet("/", () => Results.Redirect("/index.html"));

app.Run();