namespace ConsoleClient;

class PersonRepository
{
    private readonly PersonParser _parser;
    private readonly FileReader _reader;

    public PersonRepository()
    {
        _parser = new PersonParser();
        _reader = new FileReader();
    }

    public IQueryable<Person> Query()
    {
        var dataLines = _reader.ReadLines("data.csv");
        var persons = dataLines.Select(_parser.Parse);
        return persons.AsQueryable();
    }
}