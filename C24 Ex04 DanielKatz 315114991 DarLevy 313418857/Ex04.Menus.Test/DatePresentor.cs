using System.Globalization;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test;

public class DatePresentor : IFunctionality
{
    public void Execute()
    {
        Console.WriteLine($"The date is {DateTime.Today.ToString(CultureInfo.InvariantCulture)}\n");
    }
}