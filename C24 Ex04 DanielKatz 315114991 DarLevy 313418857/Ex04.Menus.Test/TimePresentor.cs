using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test;

public class TimePresentor : IFunctionality
{
    public void Execute()
    {
        Console.WriteLine($"The time is {DateTime.Now.ToString("HH:mm:ss")}\n");
    }
}