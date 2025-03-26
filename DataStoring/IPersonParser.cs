using DavidTielke.PMA.CrossCutting.DataClasses;

namespace DavidTielke.PMA.Data.DataStoring;

public interface IPersonParser
{
    Person Parse(string dataLine);
}