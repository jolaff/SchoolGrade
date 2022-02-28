namespace SchoolGrade.Library.DataAccess;

public class ClassGradeData : IClassGradeData
{
    private readonly ISubjectData _subject;
    private readonly List<ClassGradeModel> classGrades;

    public ClassGradeData(ISubjectData subject)
    {
        _subject = subject;
        classGrades = new List<ClassGradeModel>();

        CreateSeventhGrade();

        CreateFourthGrade();
    }

    private void CreateSeventhGrade()
    {
        var seventhGrade = CreateNewGrade(7);

        classGrades.Add(seventhGrade);
        seventhGrade.Subjects.Add(_subject.GetSubject("Ciências"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Educação Física"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Espanhol"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Geografia"));
        seventhGrade.Subjects.Add(_subject.GetSubject("História"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Inglês"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Matemática"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Português"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Religião"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Teatro"));
        seventhGrade.Subjects.Add(_subject.GetSubject("Intervalo"));
    }

    private void CreateFourthGrade()
    {
        var fourthGrade = CreateNewGrade(4);

        classGrades.Add(fourthGrade);
        fourthGrade.Subjects.Add(_subject.GetSubject("Arte"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Ciências"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Educação Física"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Geografia"));
        fourthGrade.Subjects.Add(_subject.GetSubject("História"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Inglês"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Matemática"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Música"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Português"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Religião"));
        fourthGrade.Subjects.Add(_subject.GetSubject("Intervalo"));
    }

    private ClassGradeModel CreateNewGrade(int grade)
    {
        var newGrade = new ClassGradeModel()
        {
            Grade = grade,
            Subjects = new List<SubjectModel>()
        };
        return newGrade;
    }

    public ClassGradeModel GetClassGrade(int grade)
    {
        foreach (var classG in classGrades)
        {
            if (classG.Grade == grade)
                return classG;
        }
        return null;
    }
}