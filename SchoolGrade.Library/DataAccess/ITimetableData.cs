namespace SchoolGrade.Library.DataAccess;

public interface ITimetableData
{
    TimetableModel GetTimeTable(int grade);
}
