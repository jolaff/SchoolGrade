namespace SchoolGrade.Library.Models;

public class StudentModel : UserModel
{
    public StudentModel()
    {
        Timetable = new TimetableModel();
    }

    public int Grade { get; set; }
    public char GradeLetter { get; set; }
    public string ThemeColor { get; set; }
    public TimetableModel Timetable { get; set; }
}