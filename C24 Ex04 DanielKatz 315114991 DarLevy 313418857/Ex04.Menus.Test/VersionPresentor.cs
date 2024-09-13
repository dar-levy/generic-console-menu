using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test;

public class VersionPresentor : IFunctionality
{
    public void Execute()
    {
        Console.WriteLine("App Version: 24.3.4.0495\n");
    }
}