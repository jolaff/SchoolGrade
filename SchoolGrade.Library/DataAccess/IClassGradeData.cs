namespace SchoolGrade.Library.DataAccess;

public interface IClassGradeData
{
    Task CreateClassGrade(ClassGradeModel classgrade);
    Task<List<ClassGradeModel>> GetAllClassGrades();
}
