using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("log.txt")
    .CreateLogger();

try
{
    AuthService auth = new AuthService();

    auth.Register("admin", "1234");

    bool success = auth.Login("admin", "1234");

    Console.WriteLine(success ? "Login Success" : "Login Failed");
}
catch (Exception ex)
{
    Log.Error(ex, "Something went wrong");
}