using DavidTielke.PMA.Logic.PersonManagement;

namespace DavidTielke.PMA.UI.ConsoleClient;

class PersonDisplayCommand : IPersonDisplayCommand
{
    private readonly IPersonManager _manager;

    public PersonDisplayCommand(IPersonManager manager)
    {
        _manager = manager;
    }

    public void DisplayAllAdults()
    {
        var adults = _manager.GetAllAdults().ToList();
        Console.WriteLine($"## Erwachsene ({adults.Count})");
        adults.ForEach(a => Console.WriteLine(a.Name));
    }
    public void DisplayAllChildren()
    {
        var children = _manager.GetAllChildren().ToList();
        Console.WriteLine($"## Kinder ({children.Count})");
        children.ForEach(c => Console.WriteLine(c.Name));
    }
}