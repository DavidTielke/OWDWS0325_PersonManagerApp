using System.Security.AccessControl;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var displayCommands = new PersonDisplayCommand();

            displayCommands.DisplayAllAdults();

            displayCommands.DisplayAllChildren();
        }
    }
}
