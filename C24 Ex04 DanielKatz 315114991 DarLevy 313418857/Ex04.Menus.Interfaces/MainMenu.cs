using System.Text;

namespace Ex04.Menus.Interfaces;

public class MainMenu
{
    internal const int k_ExitOrBackMenuItemIndex = 0; 
    private readonly string r_Title; 
    private readonly List<Option> r_Options;

    public MainMenu(string rTitle)
    {
        r_Title = rTitle;
        r_Options = new List<Option>();
    }

    public void AddOption(string i_Description, IFunctionality i_Functionality)
    {
        Option option = new Option(i_Description, this, i_Functionality);
    }
    
    public void Show()
    {
        bool isExit = false;

        while (!isExit)
        {
            Console.WriteLine(r_Title);
            displayOptions();
            Console.WriteLine("\nPlease enter your choice or 0 to exit:");
            string input = Console.ReadLine();
        }
    }

    private void displayOptions()
    {
        StringBuilder menuOutput = new StringBuilder();

        for (int i = 0; i < r_Options.Count; i++)
        {
            menuOutput.Append($"\n{i + 1} - {r_Options[i].Description}");
        }

        menuOutput.Append("\n0 - Exit");

        Console.WriteLine(menuOutput);
    }
}