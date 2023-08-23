namespace DyrOgBen;

public class User
{
    private string Name { get; set; }
    private string Password { get; set; }
    private int Point { get; set; }

    public User(string name, string password, int point)
    {
        Name = name;
        Password = password;
        Point = point;
    }

    public string GetUserName()
    {
        return Name;
    }

    public void SetUserName(string newUserName)
    {
        Name = newUserName;
    }

    public string GetUserPassword()
    {
        return Password;
    }

    public void SetUserPassword(string newUserPassword)
    {
        Password = newUserPassword;
    }

    public int GetUserPoint()
    {
        return Point;
    }

    public void SetUserPoint(int newUserPoint)
    {
        Point = newUserPoint;
    }
}