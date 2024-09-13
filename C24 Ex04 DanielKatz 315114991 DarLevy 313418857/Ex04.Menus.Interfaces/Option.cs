using System.Text;

namespace Ex04.Menus.Interfaces;

public class Option
{
    private readonly string r_Description;
    private readonly List<Option> r_Options;
    private Option m_Parent;
    private IFunctionality m_Functionality;
    
    public List<Option> Options
    {
        get
        {
            return r_Options;
        }
    }

    public Option Parent
    {
        get
        {
            return m_Parent;
        }
    }

    public void Execute()
    {
        if (m_Functionality != null)
        {
            m_Functionality.Execute();
        }
    }

    public bool IsFunctional()
    {
        return m_Functionality != null;
    }

    public Option(Option i_LastOption, string i_Description, IFunctionality i_Functionality = null)
    {
        m_Parent = i_LastOption;
        r_Description = i_Description;
        m_Functionality = i_Functionality;
        r_Options = new List<Option>();
    }
    
    public void AddOption(Option i_NewOption)
    {
        r_Options.Add(i_NewOption);
    }

    public void Show()
    {
        int currentIndex = 0;
        string exitOrBack = m_Parent == null ? "Exit" : "Back";
        
        Console.WriteLine($"{r_Description}");
        
        foreach (Option option in r_Options)
        {
            currentIndex++;
            Console.WriteLine($"{currentIndex}. {option.r_Description}");
        }
        
        Console.WriteLine($"0. {exitOrBack}");
        Console.Write($"Please enter your choice (1-{r_Options.Count()} or 0 to {exitOrBack.ToLower()}): ");
    }
}