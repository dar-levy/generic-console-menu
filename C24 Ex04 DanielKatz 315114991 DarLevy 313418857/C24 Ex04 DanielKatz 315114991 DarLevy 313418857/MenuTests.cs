
using Interfaces = Ex04.Menus.Interfaces;
using Events = Ex04.Menus.Events;


namespace C24_Ex04_DanielKatz_315114991_DarLevy_313418857
{
	public class MenuTests
	{
		public readonly Interfaces.MainMenu m_MainMenuInterface = new Interfaces.MainMenu();
		public readonly Events.MainMenu m_MainMenuEvent = new Events.MainMenu();

		private Interfaces.Option m_ShowDateTimeMenuInterface;
		private Interfaces.Option m_VersionAndDigitsMenuInterface;

		private Events.Option m_ShowDateTimeMenuDelegate;
		private Events.Option m_VersionAndDigitsMenDelegate;

		public MenuTests()
		{
			buildMenuInterfaces();
			buildMenuDelegates();
		}

		private void buildMenuInterfaces()
		{
			//Create the Interface Main Menu
			m_ShowDateTimeMenuInterface = new Interfaces.Option(m_MainMenuInterface.Root, "Show current Date/Time");
			m_ShowDateTimeMenuInterface.AddOption(new Interfaces.Option(m_ShowDateTimeMenuInterface, "Show current Time",new TimePresentor()));
			m_ShowDateTimeMenuInterface.AddOption(new Interfaces.Option(m_ShowDateTimeMenuInterface, "Show current Date", new DatePresentor()));

			m_VersionAndDigitsMenuInterface = new Interfaces.Option(m_MainMenuInterface.Root, "Version and Capitals");
			m_VersionAndDigitsMenuInterface.AddOption(new Interfaces.Option(m_VersionAndDigitsMenuInterface, "Count Capitals", new CapitalsCounter()));
			m_VersionAndDigitsMenuInterface.AddOption(new Interfaces.Option(m_VersionAndDigitsMenuInterface, "Show Version", new VersionPresentor()));

			m_MainMenuInterface.Root.AddOption(m_ShowDateTimeMenuInterface);
			m_MainMenuInterface.Root.AddOption(m_VersionAndDigitsMenuInterface);
		}

		private void buildMenuDelegates()
		{
			m_ShowDateTimeMenuEvents = new Events.Option(m_MainMenuEvent.Root, "Show current Date/Time");
			m_ShowDateTimeMenuEvents.AddOption(new Events.Option(m_ShowDateTimeMenuEvents, "Show current Time",new TimePresentor()));
			m_ShowDateTimeMenuEvents.AddOption(new Events.Option(m_ShowDateTimeMenuEvents, "Show current Date", new DatePresentor()));

			m_VersionAndDigitsMenuEvents = new Events.Option(m_MainMenuInterface.Root, "Version and Capitals");
			m_VersionAndDigitsMenuEvents.AddOption(new Events.Option(m_VersionAndDigitsMenuEvents, "Count Capitals", new CapitalsCounter()));
			m_VersionAndDigitsMenuEvents.AddOption(new Events.Option(m_VersionAndDigitsMenuEvents, "Show Version", new VersionPresentor()));

			m_MainMenuInterface.Root.AddOption(m_ShowDateTimeMenuEvents);
			m_MainMenuInterface.Root.AddOption(m_VersionAndDigitsMenuEvents);		}
		public void Show()
		{
			m_MainMenuInterface.Show();
			m_MainMenuEvent.Show();
		}
	}
}