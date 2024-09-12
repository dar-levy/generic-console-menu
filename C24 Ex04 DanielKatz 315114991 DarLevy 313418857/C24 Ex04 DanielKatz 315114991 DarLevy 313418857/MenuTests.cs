
using Ex04.Menus.Interfaces;

namespace C24_Ex04_DanielKatz_315114991_DarLevy_313418857;

public class MenuTests
{
    	public readonly MainMenu m_MainMenuInterface = new MainMenu();
		// public readonly Delegates.MainMenu m_MainMenuDelegate = new Delegates.MainMenu();

		// Members for Interface menu
		private Option m_ShowDateTimeMenuInterface;
		private Option m_VersionAndDigitsMenInterface;

		// // Members for Delegate menu
		// private Delegates.MenuItem m_ShowDateTimeMenuDelegate;
		// private Delegates.MenuActionItem m_ShowTimeDelegate;
		// private Delegates.MenuActionItem m_ShowDateDelegate;
		// private Delegates.MenuItem m_VersionAndDigitsMenDelegate;
		// private Delegates.MenuActionItem m_CountDigitsDelegate;
		// private Delegates.MenuActionItem m_ShowVersionDelegate;

		public MenuTests()
		{
			buildMenuInterfaces();
			// buildMenuDelegates();
		}

		private void buildMenuInterfaces()
		{
			//Create the Interface Main Menu
			m_ShowDateTimeMenuInterface = new Option(m_MainMenuInterface.Root, "Show Date/Time");
			m_ShowDateTimeMenuInterface.AddOption(new Option(m_ShowDateTimeMenuInterface, "Show Time", new TimePresentor()));
			m_ShowDateTimeMenuInterface.AddOption(new Option(m_ShowDateTimeMenuInterface, "Show Date", new DatePresentor()));
			
			m_VersionAndDigitsMenInterface = new Option(m_MainMenuInterface.Root, "Version and Capitals");
			m_VersionAndDigitsMenInterface.AddOption(new Option(m_VersionAndDigitsMenInterface, "Count Capitals", new CapitalsCounter()));
			m_VersionAndDigitsMenInterface.AddOption(new Option(m_VersionAndDigitsMenInterface, "Show Version", new VersionPresentor()));
			
			m_MainMenuInterface.Root.AddOption(m_ShowDateTimeMenuInterface);
			m_MainMenuInterface.Root.AddOption(m_VersionAndDigitsMenInterface);
		}

		// private void buildMenuDelegates()
		// {
		// 	//Create the Delegate Main Menu
		// 	m_ShowDateTimeMenuDelegate = new Delegates.MenuItem(m_MainMenuDelegate.RootMainMenu, "Show Date/Time");
		// 	m_ShowTimeDelegate = new Delegates.MenuActionItem(m_ShowDateTimeMenuDelegate, "Show Time");
		// 	m_ShowTimeDelegate.AddFunctionalityAction(UtilsForUI.showTime);
		// 	m_ShowDateDelegate = new Delegates.MenuActionItem(m_ShowDateTimeMenuDelegate, "Show Date");
		// 	m_ShowDateDelegate.AddFunctionalityAction(UtilsForUI.showDate);
		//
		// 	m_VersionAndDigitsMenDelegate = new Delegates.MenuItem(m_MainMenuDelegate.RootMainMenu, "Version and Digits");
		// 	m_CountDigitsDelegate = new Delegates.MenuActionItem(m_VersionAndDigitsMenDelegate, "Count Digits");
		// 	m_CountDigitsDelegate.AddFunctionalityAction(UtilsForUI.showAmountOfcountedDigitsInInput);
		// 	m_ShowVersionDelegate = new Delegates.MenuActionItem(m_VersionAndDigitsMenDelegate, "Show Version");
		// 	m_ShowVersionDelegate.AddFunctionalityAction(UtilsForUI.showVersion);
		// }
		public void Show()
		{
			m_MainMenuInterface.Show();
			// m_MainMenuDelegate.Show();
		}

}