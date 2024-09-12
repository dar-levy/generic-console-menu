using System.Text;

namespace Ex04.Menus.Interfaces;

public class MainMenu
{
    internal const int k_ExitOrBackMenuItemIndex = 0; 
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
        
            if (!isExit)
            {
                NavigateToOption(choice);
            }
        }
    }

    private bool ShouldExit(int choice)
    {
        return m_CurrentOption == m_Root && choice == k_ExitOrBackMenuItemIndex;
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

        while (!(int.TryParse(Console.ReadLine(), out selectedItemMenuIndex) &&
                 selectedItemMenuIndex >= 0 && selectedItemMenuIndex < m_CurrentOption.Options.Count))
        {
            Console.WriteLine("Invalid select! Please enter a number from the options above, try again:");
        }

        return selectedItemMenuIndex;
    }
}