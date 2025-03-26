using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring;

public interface IPersonRepository
{
    IQueryable<Person> Query();
}