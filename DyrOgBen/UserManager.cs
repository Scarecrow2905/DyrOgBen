namespace DyrOgBen;

public class UserManager
{
    private List<User?> _users;
    private User? _currentUser;
    private bool _loggedIn;

    public UserManager(bool loggedIn)
    {
        _loggedIn = loggedIn;
        _users = new List<User?>();
        _users.Add(new User("Tommy", "12345", 0));
    }
    // Variable for FindUser
    // FindUser method
    private User? FindUser(string username, string password)
    {
        return _users.Find(user => user?.GetUserName() == username && user.GetUserPassword() == password);

    }
    
    public void LogIn()
    {
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        _currentUser = FindUser(username, password);
    }
}