namespace SchoolGrade.Library.DataAccess;

public interface ITimetableData
{
    TimetableModel CreateTimeTable(List<string> times, int grade);
    TimetableModel GetTimeTable(int grade);
}
