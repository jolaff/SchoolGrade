namespace SchoolGrade.Library.DataAccess;

public class ClassGradeData : IClassGradeData
{
    private readonly List<ClassGradeModel> classGrades;
    private readonly SubjectData subject;

    public ClassGradeData()
    {
        classGrades = new List<ClassGradeModel>();

        CreateSeventhGrade();

        CreateFourthGrade();
    }

    private void CreateSeventhGrade()
    {
        var seventhGrade = NewGrade(7);

        classGrades.Add(seventhGrade);
        seventhGrade.Subjects.Add(subject.GetSubject("Ciências"));
        seventhGrade.Subjects.Add(subject.GetSubject("Educação Física"));
        seventhGrade.Subjects.Add(subject.GetSubject("Espanhol"));
        seventhGrade.Subjects.Add(subject.GetSubject("Geografia"));
        seventhGrade.Subjects.Add(subject.GetSubject("História"));
        seventhGrade.Subjects.Add(subject.GetSubject("Inglês"));
        seventhGrade.Subjects.Add(subject.GetSubject("Matemática"));
        seventhGrade.Subjects.Add(subject.GetSubject("Português"));
        seventhGrade.Subjects.Add(subject.GetSubject("Religião"));
        seventhGrade.Subjects.Add(subject.GetSubject("Teatro"));
    }

    private void CreateFourthGrade()
    {
        var fourthGrade = NewGrade(4);

        classGrades.Add(fourthGrade);
        fourthGrade.Subjects.Add(subject.GetSubject("Arte"));
        fourthGrade.Subjects.Add(subject.GetSubject("Educação Física"));
        fourthGrade.Subjects.Add(subject.GetSubject("Geografia"));
        fourthGrade.Subjects.Add(subject.GetSubject("História"));
        fourthGrade.Subjects.Add(subject.GetSubject("Inglês"));
        fourthGrade.Subjects.Add(subject.GetSubject("Matemática"));
        fourthGrade.Subjects.Add(subject.GetSubject("Música"));
        fourthGrade.Subjects.Add(subject.GetSubject("Português"));
        fourthGrade.Subjects.Add(subject.GetSubject("Religião"));
    }

    private ClassGradeModel NewGrade(int grade)
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