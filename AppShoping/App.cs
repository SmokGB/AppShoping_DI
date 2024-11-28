using AppShoping.Menu;

namespace AppShoping;

public class App : IApp
{
    private readonly IUserCommunication _menu;
    public App(IUserCommunication Menu )
    { 
      _menu= Menu;
        _menu.DisplayMenu();
    }
    public void Run()
    {
        Console.WriteLine("Dziala");
        
    }
}
