using Ex04.Menus.Interfaces;

namespace C24_Ex04_DanielKatz_315114991_DarLevy_313418857;

public class TimePresentor : IFunctionality
{
    public void Execute()
    {
        Console.WriteLine($"The time is {DateTime.Now.ToString("HH:mm:ss")}\n");
    }
}