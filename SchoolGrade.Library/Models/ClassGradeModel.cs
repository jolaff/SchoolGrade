namespace SchoolGrade.Library.Models;

public class ClassGradeModel : EntityBase
{
    public ClassGradeModel()
    {
        Subjects = new List<SubjectModel>();
    }

    public int Grade { get; set; }
    public List<SubjectModel> Subjects { get; set; }
}