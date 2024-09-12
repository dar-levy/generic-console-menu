namespace Ex04.Menus.Interfaces;

public class Option
{
    private readonly string r_Description;
    private readonly List<Option> r_Options;
    private Option m_Parent;
    private IFunctionality m_Functionality;  

    public Option(string i_Description, Option i_Parent, IFunctionality i_Functionality)
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
    
    public void AddOption(string i_Description, IFunctionality i_Functionality)
    {
        r_Options.Add(new Option(i_Description, this, i_Functionality));
    }
}