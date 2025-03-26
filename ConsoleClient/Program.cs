using System.Security.AccessControl;
using Configuration;
using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Logic.PersonManagement;
using Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace DavidTielke.PMA.UI.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollectionFactory().Create();

            serviceCollection.AddTransient<IPersonDisplayCommand, PersonDisplayCommand>();
            serviceCollection.AddTransient<App>();

            var builder = serviceCollection.BuildServiceProvider();

            var config = builder.GetRequiredService<IConfigurator>();
            config.Set("CsvPath","data.csv");
            config.Set("AgeThreshold",10);

            var app = builder.GetRequiredService<App>();
            app.Run();
        }
    }
}
