namespace SchoolGrade.Library.DataAccess;

public class SubjectData : ISubjectData
{
    private readonly List<SubjectModel> subjects;

    public SubjectData()
    {
        subjects = new List<SubjectModel>()
        {
            new SubjectModel
            {
                Name = "Arte",
                ForegroundColor = "75,167,126,1",
                BackgroundColor = "75,167,126,0.4"
            },
            new SubjectModel
            {
                Name = "Ciências",
                ForegroundColor = "222,197,141,1",
                BackgroundColor = "222,197,141,0.4"
            },
            new SubjectModel
            {
                Name = "Educação Física",
                ForegroundColor = "255,193,7,1",
                BackgroundColor = "255,193,7,0.4"
            },
            new SubjectModel
            {
                Name = "Espanhol",
                ForegroundColor = "13,110,253,1",
                BackgroundColor = "13,110,253,0.4"
            },
            new SubjectModel
            {
                Name = "Geografia",
                ForegroundColor = "111,66,193,1",
                BackgroundColor = "111,66,193,0.4"
            },
            new SubjectModel
            {
                Name = "História",
                ForegroundColor = "220,50,50,1",
                BackgroundColor = "220,50,50,0.4"
            },
            new SubjectModel
            {
                Name = "Inglês",
                ForegroundColor = "185,186,223,1",
                BackgroundColor = "185,186,223,0.4"
            },
            new SubjectModel
            {
                Name = "Matemática",
                ForegroundColor = "210,50,135,1",
                BackgroundColor = "210,50,135,0.4"
            },
            new SubjectModel
            {
                Name = "Música",
                ForegroundColor = "133,224,9,1",
                BackgroundColor = "133,224,9,0.4"
            },
            new SubjectModel
            {
                Name = "Português",
                ForegroundColor = "25,246,177,1",
                BackgroundColor = "25,246,177,0.4"
            },
            new SubjectModel
            {
                Name = "Religião",
                ForegroundColor = "220,100,30,1",
                BackgroundColor = "220,100,30,0.4"
            },
            new SubjectModel
            {
                Name = "Teatro",
                ForegroundColor = "255,150,20,1",
                BackgroundColor = "255,150,20,0.4"
            },
            new SubjectModel
            {
                Name = "Intervalo",
                ForegroundColor = "25,245,25,1",
                BackgroundColor = "25,245,25,0.4"
            }
        };
    }

    public SubjectModel GetSubject(string subject)
        => subjects.Find(sbj => sbj.Name == subject);

    public List<SubjectModel> GetAllSubjects()
        => subjects;
}