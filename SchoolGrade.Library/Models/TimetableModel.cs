namespace SchoolGrade.Library.Models;
public class TimetableModel
{
    public TimetableModel()
    {
        ClassGrade = new ClassGradeModel();
        Times = new List<string>();
        SchoolGradeTable = new Dictionary<DayOfWeek, Dictionary<string, SubjectModel>>();
    }

    public ClassGradeModel ClassGrade { get; set; }
    public List<string> Times { get; set; }
    public Dictionary<DayOfWeek, Dictionary<string, SubjectModel>> SchoolGradeTable { get; set; }
}