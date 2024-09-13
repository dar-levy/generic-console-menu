namespace Ex04.Menus.Interfaces;

public class MainMenu
{
    private readonly string r_Title;
    private Option m_InitialMenu;
    private Option m_CurrentOption;

    public Option InitialMenu
    {
        get
        {
            return m_InitialMenu;
        }
    }

    public MainMenu()
    {
        m_InitialMenu = new Option(null, "Interfaces Menu");
        m_CurrentOption = m_InitialMenu;
    }
  
    public void Show()
    {
        bool isExit = false;
    
        while (!isExit)
        {
            int choice = Choose();
            isExit = ShouldExit(choice);
            bool isBack = ShouldReturn(choice);
            
            if (isBack)
            {
                m_CurrentOption = m_CurrentOption.Parent;
            }
            else if (!isExit && choice > 0)
            {
                NavigateToOption(choice - 1);
            }
        }
    }

    private bool ShouldExit(int i_Choice)
    {
        return m_CurrentOption == m_InitialMenu && i_Choice == 0;
    }

    private bool ShouldReturn(int i_Choice)
    {
        return m_CurrentOption != m_InitialMenu && i_Choice == 0;
    }

    private void NavigateToOption(int i_Choice)
    {
        m_CurrentOption = m_CurrentOption.Options[i_Choice];
    }
    
    private int Choose()
    {
        int choice = 0;
        
        if (m_CurrentOption.IsFunctional())
        {
            m_CurrentOption.Execute();
        }
        else
        {
            m_CurrentOption.Show();
            choice = getChoice();
            Console.Clear();
        }

        return choice;
    }

    private int getChoice()
    {
        int optionIndex;

        while (!isValidChoice(Console.ReadLine(), out optionIndex))
        {
            Console.WriteLine($"Invalid input! Please enter a number 0-{m_CurrentOption.Options.Count()}");
        }

        return optionIndex;
    }

    private bool isValidChoice(string i_Input, out int o_OptionIndex)
    {
        return int.TryParse(i_Input, out o_OptionIndex) &&
               o_OptionIndex >= 0 &&
               o_OptionIndex <= m_CurrentOption.Options.Count;
    }
}