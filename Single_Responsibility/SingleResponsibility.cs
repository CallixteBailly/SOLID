public class User
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Email { get; set; } = "";
}
class UserAuth
{
    private User User;
    public UserAuth(User user)
    {
        User = user;
    }
    public bool VerifyCredentials()
    {
        // ...
    }
}
class UserSettings
{
    private User User;
    private UserAuth Auth;
    public UserSettings(User user)
    {
        User = user;
        Auth = new UserAuth(user);
    }
    public void ChangeSettings(Settings settings)
    {
        if (Auth.VerifyCredentials())
        {
            // ...
        }
    }
}