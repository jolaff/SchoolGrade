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

        luigiTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["07h05"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Inglês");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["07h55"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Geografia");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["08h45"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Português");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["09h35"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Intervalo");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["10h00"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Educação Física");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["10h50"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Ciências");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["11h40"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Geografia");

        luigiTimetable.SchoolGradeTable[DayOfWeek.Thursday]["07h05"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Português");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Thursday]["07h55"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "História");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Thursday]["08h45"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Espanhol");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Thursday]["09h35"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Intervalo");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Thursday]["10h00"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Português");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Thursday]["10h50"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Matemática");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Thursday]["11h40"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Inglês");

        luigiTimetable.SchoolGradeTable[DayOfWeek.Friday]["07h05"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "História");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Friday]["07h55"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Inglês");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Friday]["08h45"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Geografia");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Friday]["09h35"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Intervalo");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Friday]["10h00"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Matemática");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Friday]["10h50"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Educação Física");
        luigiTimetable.SchoolGradeTable[DayOfWeek.Friday]["11h40"] = _classGrade.GetClassGrade(7).Subjects.Find(s => s.Name == "Português");

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

        maluTimetable.SchoolGradeTable[DayOfWeek.Monday]["12h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Música");
        maluTimetable.SchoolGradeTable[DayOfWeek.Monday]["13h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Inglês");
        maluTimetable.SchoolGradeTable[DayOfWeek.Monday]["14h25"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "História");
        maluTimetable.SchoolGradeTable[DayOfWeek.Monday]["15h15"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Intervalo");
        maluTimetable.SchoolGradeTable[DayOfWeek.Monday]["15h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Português");
        maluTimetable.SchoolGradeTable[DayOfWeek.Monday]["16h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Português");

        maluTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["12h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Matemática");
        maluTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["13h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Matemática");
        maluTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["14h25"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Geografia");
        maluTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["15h15"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Intervalo");
        maluTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["15h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Educação Física");
        maluTimetable.SchoolGradeTable[DayOfWeek.Tuesday]["16h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Inglês");

        maluTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["12h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Português");
        maluTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["13h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Português");
        maluTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["14h25"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Inglês");
        maluTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["15h15"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Intervalo");
        maluTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["15h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Ciências");
        maluTimetable.SchoolGradeTable[DayOfWeek.Wednesday]["16h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Ciências");

        maluTimetable.SchoolGradeTable[DayOfWeek.Thursday]["12h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Arte");
        maluTimetable.SchoolGradeTable[DayOfWeek.Thursday]["13h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Educação Física");
        maluTimetable.SchoolGradeTable[DayOfWeek.Thursday]["14h25"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Inglês");
        maluTimetable.SchoolGradeTable[DayOfWeek.Thursday]["15h15"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Intervalo");
        maluTimetable.SchoolGradeTable[DayOfWeek.Thursday]["15h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Matemática");
        maluTimetable.SchoolGradeTable[DayOfWeek.Thursday]["16h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Matemática");

        maluTimetable.SchoolGradeTable[DayOfWeek.Friday]["12h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Matemática");
        maluTimetable.SchoolGradeTable[DayOfWeek.Friday]["13h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Matemática");
        maluTimetable.SchoolGradeTable[DayOfWeek.Friday]["14h25"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Religião");
        maluTimetable.SchoolGradeTable[DayOfWeek.Friday]["15h15"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Intervalo");
        maluTimetable.SchoolGradeTable[DayOfWeek.Friday]["15h45"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Inglês");
        maluTimetable.SchoolGradeTable[DayOfWeek.Friday]["16h35"] = _classGrade.GetClassGrade(4).Subjects.Find(s => s.Name == "Português");

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