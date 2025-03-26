using Configuration;
using DavidTielke.PMA.CrossCutting.DataClasses;
using DavidTielke.PMA.Data.FileStoring;

namespace DavidTielke.PMA.Data.DataStoring;

public class PersonRepository : IPersonRepository
{
    private readonly IPersonParser _parser;
    private readonly IFileReader _reader;
    private readonly IConfigurator _config;

    public PersonRepository(IPersonParser parser, IFileReader reader, IConfigurator config)
    {
        _parser = parser;
        _reader = reader;
        _config = config;
    }

    public IQueryable<Person> Query()
    {
        var reader = new FileReader();

        var csvPath = _config.Get<string>("CsvPath");

        var dataLines = _reader.ReadLines(csvPath);
        var persons = dataLines.Select(_parser.Parse);
        return persons.AsQueryable();
    }
}