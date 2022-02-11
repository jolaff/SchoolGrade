namespace SchoolGrade.Library.Models;

public class ParentModel : UserModel
{
    public ParentModel()
    {
        Students = new List<StudentModel>();
    }

    public List<StudentModel> Students { get; set; }
}