using System.Collections.Generic;
using System.Linq;

public class AuthService
{
    private List<User> users = new List<User>();

    public void Register(string username, string password)
    {
        string hashed = HashHelper.HashPassword(password);

        users.Add(new User
        {
            Username = username,
            HashedPassword = hashed
        });

        Console.WriteLine("User Registered Successfully");
    }

    public bool Login(string username, string password)
    {
        string hashed = HashHelper.HashPassword(password);

        var user = users.FirstOrDefault(u =>
            u.Username == username &&
            u.HashedPassword == hashed);

        return user != null;
    }
}