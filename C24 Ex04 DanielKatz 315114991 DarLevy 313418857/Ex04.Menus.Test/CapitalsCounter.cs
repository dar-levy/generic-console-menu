using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test;

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