namespace SchoolGrade.Library.DataAccess;

public class MongoSubjectData : ISubjectData
{
    private readonly IMongoCollection<SubjectModel> _subjects;

    public MongoSubjectData(IDbConnection db)
    {
        _subjects = db.SubjectCollection;
    }

    public async Task<List<SubjectModel>> GetAllSubjects()
    {
        var results = await _subjects.FindAsync(_ => true);
        return results.ToList();
    }

    public async Task<SubjectModel> GetSubject(string id)
    {
        var results = await _subjects.FindAsync(s => s.Id == id);
        return results.FirstOrDefault();
    }

    public Task CreateSubject(SubjectModel subject)
    {
        return _subjects.InsertOneAsync(subject);
    }

    public Task UpdateSubject(SubjectModel subject)
    {
        var filter = Builders<SubjectModel>.Filter.Eq("Id", subject.Id);
        return _subjects.ReplaceOneAsync(filter, subject, new ReplaceOptions { IsUpsert = true });
    }
}