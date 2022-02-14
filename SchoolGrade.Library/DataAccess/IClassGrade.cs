namespace SchoolGrade.Library.DataAccess;

public interface IClassGrade
{
    Task CreateClassGrade(ClassGradeModel classgrade);
    Task<List<ClassGradeModel>> GetAllClassGrades();
}
