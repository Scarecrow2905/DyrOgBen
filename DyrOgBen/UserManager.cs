namespace DyrOgBen;

public class UserManager
{
    private List<User?> _users;
    private User? _currentUser;
    private bool _loggedIn;

    public UserManager()
    {
        _users = new List<User?>();
        _users.Add(new User("Tommy", "12345", 0));
    }
    // Variable for FindUser
    // FindUser method
    private User? FindUser(string username, string password)
    {
        return _users.Find(user => user?.GetUserName() == username && user.GetUserPassword() == password);
    }
    
    public User? LogIn()
    {
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        _currentUser = FindUser(username, password);

        if (_currentUser != null) // This means ! = null, just as a future reference
        {
            _loggedIn = true;
            Console.WriteLine("Logged in as: " + _currentUser.GetUserName());
            Console.WriteLine("Points: " + _currentUser.GetUserPoint());
            return _currentUser;
        }
        
        _loggedIn = false;
        Console.WriteLine("Didn't find a user that matched your criteria, please try again. ");
        return null;
    }

    public void LogOut()
    {
        _loggedIn = false;
        Console.WriteLine("Logged out as " + _currentUser?.GetUserName());
        _currentUser = null; // Clear user reference, might need to look more into this later
    }
}