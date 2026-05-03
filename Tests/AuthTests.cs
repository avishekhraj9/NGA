using NUnit.Framework;



public class AuthTests
{
    private AuthService auth;

    [SetUp]
    public void Setup()
    {
        auth = new AuthService();
    }

    [Test]
    public void Register_Login_Test()
    {
        auth.Register("test", "123");

        bool result = auth.Login("test", "123");

        Assert.IsTrue(result);
    }
}