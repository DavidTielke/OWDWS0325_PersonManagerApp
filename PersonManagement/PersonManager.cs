using Configuration;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.DataStoring;

namespace DavidTielke.PMA.Logic.PersonManagement;

public class PersonManager : IPersonManager
{
    private readonly IPersonRepository _repository;
    private readonly IConfigurator _config;

    public PersonManager(IPersonRepository repository, IConfigurator config)
    {
        _repository = repository;
        _config = config;
    }

    public IQueryable<Person> GetAllAdults()
    {
        var ageThreshold = _config.Get<int>("AgeThreshold");
        return _repository.Query().Where(p => p.Age >= ageThreshold);
    }

    public IQueryable<Person> GetAllChildren()
    {
        var ageThreshold = _config.Get<int>("AgeThreshold");
        return _repository.Query().Where(p => p.Age < ageThreshold);
    }
}