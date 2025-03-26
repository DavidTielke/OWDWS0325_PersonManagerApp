namespace DavidTielke.PMA.UI.ConsoleClient;

internal class App
{
    private readonly IPersonDisplayCommand _displayCommand;

    public App(IPersonDisplayCommand displayCommand)
    {
        _displayCommand = displayCommand;
    }

    public void Run()
    {
        _displayCommand.DisplayAllAdults();
        _displayCommand.DisplayAllChildren();
    }
}