namespace SchoolGrade.Library.Models;

public abstract class UserModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string Email { get; set; }
}