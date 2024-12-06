namespace AppShoping;
using AppShoping.Entities;
using AppShoping.Menu;
using AppShoping.Repositories;
using Microsoft.Extensions.DependencyInjection;
public class App : IApp
{
    private readonly IUserCommunication _menu;
    private readonly SqlRepository<Food> _food;
    private readonly SqlRepository<BioFood> _bioFood;

    public App(IUserCommunication Menu, SqlRepository<Food> Food, SqlRepository<BioFood> BioFood)
    {
        _menu = Menu;
        _food = Food;
        _bioFood = BioFood;

    }
    public void Run()
    {
        _menu.DisplayMenu();
        _menu.RunChoose();
    }
}

