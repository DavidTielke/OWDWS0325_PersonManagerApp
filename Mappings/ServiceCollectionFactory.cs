using Configuration;
using DavidTielke.PMA.Data.DataStoring;
using DavidTielke.PMA.Data.FileStoring;
using DavidTielke.PMA.Logic.PersonManagement;
using Microsoft.Extensions.DependencyInjection;

namespace Mappings
{
    public class ServiceCollectionFactory
    {
        public IServiceCollection Create()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IPersonManager, PersonManager>();
            serviceCollection.AddSingleton<IPersonRepository, PersonRepository>();
            serviceCollection.AddTransient<IPersonParser, PersonParser>();
            serviceCollection.AddTransient<IFileReader, FileReader>();

            serviceCollection.AddSingleton<IConfigurator, Configurator>();

            return serviceCollection;
        }
    }
}
