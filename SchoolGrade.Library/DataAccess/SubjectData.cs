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
                ForegroundColor = "172,140,164,1",
                BackgroundColor = "172,140,164,0.4"
            },
            new SubjectModel
            {
                Name = "Espanhol",
                ForegroundColor = "43,75,245,1",
                BackgroundColor = "43,75,245,0.4"
            },
            new SubjectModel
            {
                Name = "Geografia",
                ForegroundColor = "127,66,185,1",
                BackgroundColor = "127,66,185,0.4"
            },
            new SubjectModel
            {
                Name = "História",
                ForegroundColor = "110,152,81,1",
                BackgroundColor = "110,152,81,0.4"
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
                ForegroundColor = "6,251,180,1",
                BackgroundColor = "6,251,180,0.4"
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
                ForegroundColor = "89,77,118,1",
                BackgroundColor = "89,77,118,0.4"
            },
            new SubjectModel
            {
                Name = "Teatro",
                ForegroundColor = "5,165,48,1",
                BackgroundColor = "5,165,48,0.4"
            },
            new SubjectModel
            {
                Name = "Intervalo",
                ForegroundColor = "0,200,0,1",
                BackgroundColor = "0,200,0,0.4"
            }
        };
    }

    public SubjectModel GetSubject(string subject)
        => subjects.Find(sbj => sbj.Name == subject);
}