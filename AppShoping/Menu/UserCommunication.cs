using AppShoping.Entities;
using AppShoping.Repositories;
using AppShoping.Repositories.Extensions;

namespace AppShoping.Menu;

public class UserCommunication : IUserCommunication
{
    private List<string> shopMenu = new() { "1 - Produkty do zakupu", "2 - Dodaj produkt", "3 - Dodaj produkt bio",
        "4 - Usuń produkt z listy zakupów", "5 - Wyjście z programu"};


    private void Alert()
    {
        throw new NotImplementedException();
    }

    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Wykaz zakupów do zrobienia\n");
        foreach (var i in shopMenu) Console.WriteLine(i);
        Console.WriteLine("\n------------- Wybierz opcję [1- 5] ---------------\n");
    }
}


