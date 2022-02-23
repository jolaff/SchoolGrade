namespace SchoolGrade.Library.DataAccess;

public class StudentData : IStudentData
{
    private readonly ITimetableData _timetable;
    private readonly List<StudentModel> students;

    public StudentData(ITimetableData timetable)
    {
        _timetable = timetable;
        students = new List<StudentModel>();

        students.Add(LuigiBSL);
        students.Add(MaluBSL);

        LuigiBSL.Timetable = timetable.GetTimeTable(LuigiBSL.Grade);
        MaluBSL.Timetable = timetable.GetTimeTable(MaluBSL.Grade);
    }

    StudentModel LuigiBSL = new StudentModel()
    {
        FirstName = "Luigi",
        LastName = "Bastos de Souza Landgraf",
        DisplayName = "Lu",
        Email = "luigi.landgraf@aluno.imaculada.com.br",
        Grade = 7,
        GradeLetter = 'A',
        IconImage = "android"
    };

    StudentModel MaluBSL = new StudentModel()
    {
        FirstName = "Maria Luísa",
        LastName = "Bastos de Souza Landgraf",
        DisplayName = "Malu",
        Email = "maria.landgraf@aluno.imaculada.com.br",
        Grade = 4,
        GradeLetter = 'D',
        IconImage = "gavel"
    };

    public List<StudentModel> GetAllStudents()
        => students;

    public StudentModel GetStudent(string display)
    {
        foreach (var student in students)
        {
            if (student.DisplayName == display)
                return student;
        }
        return null;
    }
}