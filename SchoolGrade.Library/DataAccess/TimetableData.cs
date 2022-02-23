namespace SchoolGrade.Library.DataAccess;

public class TimetableData : ITimetableData
{
    private readonly IClassGradeData _classGrade;
    private readonly List<TimetableModel> timetables;

    public TimetableData(IClassGradeData classGrade)
    {
        _classGrade = classGrade;
        timetables = new List<TimetableModel>();

        CreateLuigiTimetable();

        CreateMaluTimetable();
    }

    private void CreateLuigiTimetable()
    {
        List<string> seventhGradeTimes = new List<string>()
        {
            "07h05",
            "07h55",
            "08h45",
            "09h35",
            "10h00",
            "10h50",
            "11h40"
        };

        var luigiTimetable = CreateNewTimetable(seventhGradeTimes, 7);

        luigiTimetable.SchoolGradeTable[DayOfWeek.Monday]["07h05"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Religião");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Monday]["07h55"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Inglês");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Monday]["08h45"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Matemática");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Monday]["09h35"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Intervalo");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Monday]["10h00"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Português");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Monday]["10h50"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Matemática");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Monday]["11h40"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Ciências");

        luigiTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["07h05"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Religião");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["07h55"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Inglês");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["08h45"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Teatro");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["09h35"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Intervalo");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["10h00"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Matemática");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["10h50"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Ciências");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["11h40"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Espanhol");

        timetables.Add(luigiTimetable);
    }

    private void CreateMaluTimetable()
    {
        List<string> fourthGradeTimes = new List<string>()
        {
            "12h45",
            "13h35",
            "14h25",
            "15h15",
            "15h45",
            "16h35"
        };

        var maluTimetable = CreateNewTimetable(fourthGradeTimes, 4);

        timetables.Add(maluTimetable);
    }

    private TimetableModel CreateNewTimetable(List<string> times, int grade)
    {
        var timetable = new TimetableModel()
        {
            ClassGrade = _classGrade.GetClassGrade(grade),
            Times = times
        };

        for (int i = 1; i < 6; i++)
        {
            timetable.SchoolGradeTable.Add((DayOfWeek)i, new Dictionary<string, SubjectModel>());
            foreach (string time in times)
            {
                timetable.SchoolGradeTable[(DayOfWeek)i].Add(time, new SubjectModel());
            }
        }

        return timetable;
    }

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