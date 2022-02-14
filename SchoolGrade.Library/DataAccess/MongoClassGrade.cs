namespace SchoolGrade.Library.DataAccess;

public class MongoClassGrade : IClassGrade
{
    private readonly IMongoCollection<ClassGradeModel> _classgrades;

    public MongoClassGrade(IDbConnection db)
    {
        _classgrades = db.ClassGradeCollection;
    }

    public async Task<List<ClassGradeModel>> GetAllClassGrades()
    {
        var results = await _classgrades.FindAsync(_ => true);
        return results.ToList();
    }

    public Task CreateClassGrade(ClassGradeModel classgrade)
    {
        return _classgrades.InsertOneAsync(classgrade);
    }
}