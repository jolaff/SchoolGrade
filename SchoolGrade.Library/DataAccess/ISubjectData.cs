namespace SchoolGrade.Library.DataAccess;

public interface ISubjectData
{
    List<SubjectModel> GetAllSubjects();
    SubjectModel GetSubject(string subject);
}
