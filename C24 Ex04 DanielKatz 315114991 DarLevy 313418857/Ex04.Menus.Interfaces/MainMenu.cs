using System.Text;

namespace Ex04.Menus.Interfaces;

public class MainMenu
{
    private readonly string r_Title;
    private Option m_Root;
    private Option m_CurrentOption;

    public Option Root
    {
        get
        {
            return m_Root;
        }

        set
        {
            m_Root = value;
        }
    }

    // Methods
    public MainMenu()
    {
        m_Root = new Option(null, "Main Menu");
        m_CurrentOption = m_Root;
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

    private bool ShouldExit(int choice)
    {
        return m_CurrentOption == m_Root && choice == 0;
    }

    private bool ShouldReturn(int choice)
    {
        return m_CurrentOption != m_Root && choice == 0;
    }

    private void NavigateToOption(int choice)
    {
        m_CurrentOption = m_CurrentOption.Options[choice];
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
        int selectedItemMenuIndex;

        while (!isValidChoice(Console.ReadLine(), out selectedItemMenuIndex))
        {
            Console.WriteLine("Invalid selection! Please enter a number from the options above, try again:");
        }

        return selectedItemMenuIndex;
    }

    private bool isValidChoice(string input, out int selectedItemMenuIndex)
    {
        return int.TryParse(input, out selectedItemMenuIndex) &&
               selectedItemMenuIndex >= 0 &&
               selectedItemMenuIndex <= m_CurrentOption.Options.Count;
    }
}