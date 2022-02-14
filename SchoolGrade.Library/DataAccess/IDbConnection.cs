namespace SchoolGrade.Library.DataAccess;

public interface IDbConnection
{
    string DbName { get; }
    string ParentCollectionName { get; }
    string StudentCollectionName { get; }
    string SubjectCollectionName { get; }
    string ClassGradeCollectionName { get; }
    string TimetableCollectionName { get; }
    MongoClient Client { get; }
    IMongoCollection<ParentModel> ParentCollection { get; }
    IMongoCollection<StudentModel> StudentCollection { get; }
    IMongoCollection<SubjectModel> SubjectCollection { get; }
    IMongoCollection<ClassGradeModel> ClassGradeCollection { get; }
    IMongoCollection<TimetableModel> TimetableCollection { get; }
}
