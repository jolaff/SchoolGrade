namespace SchoolGrade.Library.DataAccess;

public interface ITimetableData
{
    Task CreateTimetable(TimetableModel timetable);
    Task<List<TimetableModel>> GetAllTimetables();
}
