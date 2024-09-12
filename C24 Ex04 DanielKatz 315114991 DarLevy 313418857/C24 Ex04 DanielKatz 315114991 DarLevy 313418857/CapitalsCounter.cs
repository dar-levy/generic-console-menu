using Ex04.Menus.Interfaces;

namespace C24_Ex04_DanielKatz_315114991_DarLevy_313418857;

public class CapitalsCounter : IFunctionality
{
    public void Execute()
    {
        int capitalsCount = 0;

        Console.WriteLine("Enter your sentence:");
        string sentence = Console.ReadLine();

        foreach (char letter in sentence)
        {
            if (Char.IsUpper(letter))
            {
                capitalsCount += 1;
            }
        }

        Console.WriteLine($"Number of Capitals: {capitalsCount}\n");
    }
}