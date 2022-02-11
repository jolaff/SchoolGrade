namespace SchoolGrade.Library.Models;

public class StudentModel : UserModel
{
    public StudentModel()
    {
        Timetable = new TimetableModel();
    }

    public int Grade { get; set; }
    public TimetableModel Timetable { get; set; }
}