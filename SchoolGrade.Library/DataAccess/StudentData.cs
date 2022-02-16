namespace SchoolGrade.Library.DataAccess;

public class StudentData : IStudentData
{
    private readonly List<StudentModel> students;

    public StudentData()
    {
        students = new List<StudentModel>();

        students.Add(LuigiBSL);
        students.Add(MaluBSL);
    }

    StudentModel LuigiBSL = new StudentModel()
    {
        FirstName = "Luigi",
        LastName = "Bastos de Souza Landgraf",
        DisplayName = "Lu",
        Email = "luigi.landgraf@aluno.imaculada.com.br",
        Grade = 7,
        GradeLetter = 'A',
        ThemeColor = "#0000FF"
    };

    StudentModel MaluBSL = new StudentModel()
    {
        FirstName = "Maria Luísa",
        LastName = "Bastos de Souza Landgraf",
        DisplayName = "Malu",
        Email = "maria.landgraf@aluno.imaculada.com.br",
        Grade = 4,
        GradeLetter = 'D',
        ThemeColor = "#FF0000"
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