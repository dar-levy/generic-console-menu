namespace Ex04.Menus.Interfaces;

public class Option
{
    private readonly string r_Description;
    private readonly List<Option> r_Options = new List<Option>();
    private Option m_ParentMenu;

    public Option(string i_Description, Option i_ParentMenu)
    {
        r_Description = i_Description;
        m_ParentMenu = i_ParentMenu;
    }

    public int OptionsCount
    {
        get 
        { 
            return r_Options.Count; 
        }
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
}