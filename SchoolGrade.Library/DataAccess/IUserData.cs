namespace SchoolGrade.Library.DataAccess;

public interface IUserData
{
    Task CreateParentUser(ParentModel parent);
    Task CreateStudentUser(StudentModel student);
    Task<ParentModel> GetParentFromAuthentication(string objectId);
    Task<List<ParentModel>> GetParentsAsync();
    Task<ParentModel> GetParentUser(string id);
    Task<StudentModel> GetStudentFromAuthentication(string objectId);
    Task<List<StudentModel>> GetStudentsAsync();
    Task<StudentModel> GetStudentUser(string id);
    Task UpdateParentUser(ParentModel parent);
    Task UpdateStudentUser(StudentModel student);
}
