namespace SchoolGrade.Library.DataAccess;

public interface ISubjectData
{
    Task CreateSubject(SubjectModel subject);
    Task<List<SubjectModel>> GetAllSubjects();
    Task<SubjectModel> GetSubject(string id);
    Task UpdateSubject(SubjectModel subject);
}
