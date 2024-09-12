using System.Text;

namespace Ex04.Menus.Interfaces;

public class Option : IMenu
{
    private readonly string r_Description;
    private readonly List<Option> r_Options;
    private IMenu m_Parent;
    private IFunctionality m_Functionality;

    public Option(string i_Description, IMenu i_Parent, IFunctionality i_Functionality)
    {
        r_Description = i_Description;
        m_Parent = i_Parent;
        m_Functionality = i_Functionality;
        r_Options = new List<Option>();
    }

    public List<Option> Options
    {
        get
        {
            return r_Options; 
        }
    }

    public string Description
    {
        get 
        {
            return r_Description;
        }
    }
    
    public IFunctionality Funtionality
    {
        get 
        {
            return m_Functionality;
        }
    }

    public int Count
    {
        get
        {
            return r_Options.Count;
        }
    }
    
    public void AddOption(string i_Description, IFunctionality i_Functionality)
    {
        r_Options.Add(new Option(i_Description, this, i_Functionality));
    }
    
    public void Show()
    {
        StringBuilder menuOutput = new StringBuilder(r_Description);

        for (int i = 0; i < r_Options.Count; i++)
        {
            menuOutput.Append($"\n{i + 1} - {r_Options[i].Description}");
        }

        menuOutput.Append(m_Parent == null ? "\n0 - Exit" : "\n0 - Back");

        Console.WriteLine(menuOutput);
    }
    
    public IMenu ExecuteSubOption(int i_Choice)
    {
        Console.Clear();

        if (i_Choice == 0)
        {
            return m_Parent;
        }

        Option selectedOption = r_Options[i_Choice];

        if (selectedOption.Count > 0)
        {
            return selectedOption;
        }

        selectedOption.Funtionality.Execute();
        
        return this;
    }
}