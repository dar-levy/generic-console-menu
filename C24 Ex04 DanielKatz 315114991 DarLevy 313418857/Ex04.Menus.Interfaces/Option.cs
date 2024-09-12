using System.Text;

namespace Ex04.Menus.Interfaces;

public class Option
{
    private readonly string r_Description;
    private readonly List<Option> r_Options;
    private Option m_Parent;
    private IFunctionality m_Functionality;

    public string Description
    {
        get
        {
            return r_Description;
        }
    }
		
    public List<Option> Options
    {
        get
        {
            return r_Options;
        }
    }

    public Option(Option i_LastOption, string i_Description)
    {
        m_Parent = i_LastOption;
        r_Description = i_Description;
    }
    
    // TODO - Add AddOption(Option option)

    internal void Show()
    {
        int currentIndex = MainMenu.k_ExitOrBackMenuItemIndex;

        Console.WriteLine($"{r_Description}");
        Console.WriteLine($"{MainMenu.k_ExitOrBackMenuItemIndex}. {(m_Parent == null ? "Exit" : "Back")}");
        foreach (Option option in r_Options)
        {
            currentIndex++;
            Console.WriteLine($"{currentIndex}. {option.r_Description}");
        }
        
        // TODO: Change static text
        Console.Write("Please enter the option number you choose from the above: ");
    }

    internal virtual void OnSelect()
    {
    }
}