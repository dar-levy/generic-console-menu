using System.Text;

namespace Ex04.Menus.Events;

public class Option
{
    private readonly string r_Description;
    private readonly List<Option> r_Options;
    private Option m_Parent;
    private Action m_Functionality;

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
            m_Functionality.Invoke();
        }
    }

    public bool IsFunctional()
    {
        return m_Functionality != null;
    }

    public Option(Option i_LastOption, string i_Description, Action i_Functionality = null)
    {
        m_Parent = i_LastOption;
        r_Description = i_Description;
        m_Functionality += i_Functionality;
        r_Options = new List<Option>();
    }
    
    public void AddOption(Option i_NewOption)
    {
        r_Options.Add(i_NewOption);
    }

    public void Show()
    {
        int currentIndex = 0;
        Console.WriteLine($"{r_Description}");
        Console.WriteLine($"{currentIndex}. {(m_Parent == null ? "Exit" : "Back")}");
        foreach (Option option in r_Options)
        {
            currentIndex++;
            Console.WriteLine($"{currentIndex}. {option.r_Description}");
        }
        
        // TODO: Change static text
        Console.Write("Please enter the option number you choose from the above: ");
    }
}