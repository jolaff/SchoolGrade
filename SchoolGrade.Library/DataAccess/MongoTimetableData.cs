namespace SchoolGrade.Library.DataAccess;

public class MongoTimetableData : ITimetableData
{
    private readonly IMongoCollection<TimetableModel> _timetables;

    public MongoTimetableData(IDbConnection db)
    {
        _timetables = db.TimetableCollection;
    }

    public async Task<List<TimetableModel>> GetAllTimetables()
    {
        var results = await _timetables.FindAsync(_ => true);
        return results.ToList();
    }

    public Task CreateTimetable(TimetableModel timetable)
    {
        return _timetables.InsertOneAsync(timetable);
    }
}