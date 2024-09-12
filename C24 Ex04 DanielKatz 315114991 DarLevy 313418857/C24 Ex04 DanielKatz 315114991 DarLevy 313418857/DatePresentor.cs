using System.Globalization;
using Ex04.Menus.Interfaces;

namespace C24_Ex04_DanielKatz_315114991_DarLevy_313418857;

public class DatePresentor : IFunctionality
{
    public void Execute()
    {
        Console.WriteLine($"The date is {DateTime.Today.ToString(CultureInfo.InvariantCulture)}\n");
    }
}