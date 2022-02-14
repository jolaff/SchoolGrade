namespace SchoolGrade.Library.DataAccess;

public class MongoUserData : IUserData
{
    private readonly IMongoCollection<ParentModel> _parents;
    private readonly IMongoCollection<StudentModel> _students;

    public MongoUserData(IDbConnection db)
    {
        _parents = db.ParentCollection;
        _students = db.StudentCollection;
    }

    public async Task<List<ParentModel>> GetParentsAsync()
    {
        var results = await _parents.FindAsync(_ => true);
        return results.ToList();
    }

    public async Task<List<StudentModel>> GetStudentsAsync()
    {
        var results = await _students.FindAsync(_ => true);
        return results.ToList();
    }

    public async Task<ParentModel> GetParentUser(string id)
    {
        var results = await _parents.FindAsync(p => p.Id == id);
        return results.FirstOrDefault();
    }

    public async Task<StudentModel> GetStudentUser(string id)
    {
        var results = await _students.FindAsync(p => p.Id == id);
        return results.FirstOrDefault();
    }

    public async Task<ParentModel> GetParentFromAuthentication(string objectId)
    {
        var results = await _parents.FindAsync(p => p.ObjectIdentifier == objectId);
        return results.FirstOrDefault();
    }

    public async Task<StudentModel> GetStudentFromAuthentication(string objectId)
    {
        var results = await _students.FindAsync(p => p.ObjectIdentifier == objectId);
        return results.FirstOrDefault();
    }

    public Task CreateParentUser(ParentModel parent)
    {
        return _parents.InsertOneAsync(parent);
    }

    public Task CreateStudentUser(StudentModel student)
    {
        return _students.InsertOneAsync(student);
    }

    public Task UpdateParentUser(ParentModel parent)
    {
        var filter = Builders<ParentModel>.Filter.Eq("Id", parent.Id);
        return _parents.ReplaceOneAsync(filter, parent, new ReplaceOptions { IsUpsert = true });
    }

    public Task UpdateStudentUser(StudentModel student)
    {
        var filter = Builders<StudentModel>.Filter.Eq("Id", student.Id);
        return _students.ReplaceOneAsync(filter, student, new ReplaceOptions { IsUpsert = true });
    }
}