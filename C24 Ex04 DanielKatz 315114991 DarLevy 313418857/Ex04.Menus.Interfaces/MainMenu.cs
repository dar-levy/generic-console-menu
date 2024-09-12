namespace Ex04.Menus.Interfaces;

public class MainMenu : IMenu
{
    private readonly string _iTitle; 
    private readonly List<Option> r_Options;

    public MainMenu(string i_Title)
    {
        _iTitle = i_Title;
        r_Options = new List<Option>();
    }

    public void AddOption(string i_Description, IFunctionality i_Functionality)
    {
        Option option = new Option(i_Description, this, i_Functionality);
    }

    public void Show()
    {
        throw new NotImplementedException();
    }
}