
using Interfaces = Ex04.Menus.Interfaces;
using Events = Ex04.Menus.Events;


namespace C24_Ex04_DanielKatz_315114991_DarLevy_313418857
{
	public class MenuTests
	{
		public readonly Interfaces.MainMenu m_MainMenuInterface = new Interfaces.MainMenu();
		public readonly Events.MainMenu m_MainMenuEvent = new Events.MainMenu();

		private Interfaces.Option m_ShowDateTimeMenuInterface;
		private Interfaces.Option m_VersionAndCapitalsMenuInterface;

		private Events.Option m_ShowDateTimeMenuEvent;
		private Events.Option m_VersionAndCapitalsMenEvent;

		public MenuTests()
		{
			buildMenuInterfaces();
			buildMenuEvents();
		}

		private void buildMenuInterfaces()
		{
			//Create the Interface Main Menu
			m_ShowDateTimeMenuInterface = new Interfaces.Option(m_MainMenuInterface.Root, "Show current Date/Time");
			m_ShowDateTimeMenuInterface.AddOption(new Interfaces.Option(m_ShowDateTimeMenuInterface, "Show current Time",new TimePresentor()));
			m_ShowDateTimeMenuInterface.AddOption(new Interfaces.Option(m_ShowDateTimeMenuInterface, "Show current Date", new DatePresentor()));

			m_VersionAndCapitalsMenuInterface = new Interfaces.Option(m_MainMenuInterface.Root, "Version and Capitals");
			m_VersionAndCapitalsMenuInterface.AddOption(new Interfaces.Option(m_VersionAndCapitalsMenuInterface, "Count Capitals", new CapitalsCounter()));
			m_VersionAndCapitalsMenuInterface.AddOption(new Interfaces.Option(m_VersionAndCapitalsMenuInterface, "Show Version", new VersionPresentor()));

			m_MainMenuInterface.Root.AddOption(m_ShowDateTimeMenuInterface);
			m_MainMenuInterface.Root.AddOption(m_VersionAndCapitalsMenuInterface);
		}

		private void buildMenuEvents()
		{
			m_ShowDateTimeMenuEvent = new Events.Option(m_MainMenuEvent.Root, "Show current Date/Time");
			m_ShowDateTimeMenuEvent.AddOption(new Events.Option(m_ShowDateTimeMenuEvent, "Show current Time",new TimePresentor()));
			m_ShowDateTimeMenuEvent.AddOption(new Events.Option(m_ShowDateTimeMenuEvent, "Show current Date", new DatePresentor()));

			m_VersionAndCapitalsMenEvent = new Events.Option(m_MainMenuEvent.Root, "Version and Capitals");
			m_VersionAndCapitalsMenEvent.AddOption(new Events.Option(m_VersionAndCapitalsMenEvent, "Count Capitals", new CapitalsCounter()));
			m_VersionAndCapitalsMenEvent.AddOption(new Events.Option(m_VersionAndCapitalsMenEvent, "Show Version", new VersionPresentor()));

			m_MainMenuEvent.Root.AddOption(m_ShowDateTimeMenuEvent);
			m_MainMenuEvent.Root.AddOption(m_VersionAndCapitalsMenEvent);		
		}
		public void Show()
		{
			m_MainMenuInterface.Show();
			m_MainMenuEvent.Show();
		}
	}
}