namespace SchoolGrade.Library.DataAccess;

public interface IStudentData
{
    List<StudentModel> GetAllStudents();
    StudentModel GetStudent(string display);
}
