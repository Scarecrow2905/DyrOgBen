namespace DyrOgBen;

public class User
{
    private string Name { get; set; }
    private string Password { get; set; }
    private int Point { get; set; }

    public User(string name, string password, int point)
    {
        this.Name = name;
        this.Password = password;
        this.Point = point;

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
    //public void SetUserPassword(string newUserPassw)
    
}