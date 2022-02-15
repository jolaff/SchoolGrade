using Microsoft.Extensions.Configuration;

namespace SchoolGrade.Library.DataAccess;

public class DbConnection : IDbConnection
{
    private readonly IConfiguration _config;
    private readonly IMongoDatabase _db;
    private string _connectionId = "MongoDB";

    public string DbName { get; private set; }
    public string ParentCollectionName { get; private set; } = "parents";
    public string StudentCollectionName { get; private set; } = "students";
    public string SubjectCollectionName { get; private set; } = "subjects";
    public string ClassGradeCollectionName { get; private set; } = "classgrades";
    public string TimetableCollectionName { get; private set; } = "timetables";

    public MongoClient Client { get; private set; }
    public IMongoCollection<ParentModel> ParentCollection { get; private set; }
    public IMongoCollection<StudentModel> StudentCollection { get; private set; }
    public IMongoCollection<SubjectModel> SubjectCollection { get; private set; }
    public IMongoCollection<ClassGradeModel> ClassGradeCollection { get; private set; }
    public IMongoCollection<TimetableModel> TimetableCollection { get; private set; }

    public DbConnection(IConfiguration config)
    {
        _config = config;
        var settings = MongoClientSettings.FromConnectionString(_config.GetConnectionString(_connectionId));
        Client = new MongoClient(settings);
        DbName = _config["DatabaseName"];
        _db = Client.GetDatabase(DbName);

        ParentCollection = _db.GetCollection<ParentModel>(ParentCollectionName);
        StudentCollection = _db.GetCollection<StudentModel>(StudentCollectionName);
        SubjectCollection = _db.GetCollection<SubjectModel>(SubjectCollectionName);
        ClassGradeCollection = _db.GetCollection<ClassGradeModel>(ClassGradeCollectionName);
        TimetableCollection = _db.GetCollection<TimetableModel>(TimetableCollectionName);
    }
}