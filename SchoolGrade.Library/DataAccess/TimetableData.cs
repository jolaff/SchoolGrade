namespace SchoolGrade.Library.DataAccess;

public class TimetableData : ITimetableData
{
    private readonly List<TimetableModel> timetables;
    private readonly ClassGradeData classGrade;

    public TimetableData()
    {
        timetables = new List<TimetableModel>();

        timetables.Add(CreateTimeTable(seventhGradeTimes, 7));
    }

    public TimetableModel CreateTimeTable(List<string> times, int grade)
    {
        var timeTable = new TimetableModel()
        {
            ClassGrade = classGrade.GetClassGrade(grade),
            Times = times
        };
        return timeTable;
    }

    private readonly List<string> seventhGradeTimes = new List<string>()
    {
        "07h05",
        "07h55",
        "08h45",
        "09h35",
        "10h00",
        "10h50",
        "11h40"
    };

    public TimetableModel GetTimeTable(int grade)
    {
        foreach (var tt in timetables)
        {
            if (tt.ClassGrade.Grade == grade)
                return tt;
        }
        return null;
    }
}