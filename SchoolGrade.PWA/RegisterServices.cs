using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace SchoolGrade.PWA;

public static class RegisterServices
{
    public static void ConfigureServices(this WebAssemblyHostBuilder builder)
    {
        builder.RootComponents.Add<App>("#app");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddSingleton<IDbConnection, DbConnection>();
        builder.Services.AddSingleton<ISubjectData, MongoSubjectData>();
        builder.Services.AddSingleton<IClassGradeData, MongoClassGradeData>();
        builder.Services.AddSingleton<ITimetableData, MongoTimetableData>();
        builder.Services.AddSingleton<IUserData, MongoUserData>();

        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
    }
}