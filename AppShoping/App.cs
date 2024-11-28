using AppShoping.Menu;

namespace AppShoping;

public class App : IApp
{
    private readonly IUserCommunication _menu;
    public App(IUserCommunication Menu)
    {
        _menu = Menu;
   
    }
    public void Run()
    {        
        _menu.DisplayMenu();
    }
}
