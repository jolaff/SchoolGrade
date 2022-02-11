namespace SchoolGrade.Library.Models;
public class TimetableModel : EntityBase
{
    public TimetableModel()
    {
        SchoolGradeTable = new Dictionary<DayOfWeek, Dictionary<string, SubjectModel>>();
    }

    public ClassGradeModel ClassGrade { get; set; }
    public List<string> Times { get; set; }
    public Dictionary<DayOfWeek, Dictionary<string, SubjectModel>> SchoolGradeTable { get; set; }
}