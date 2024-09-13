
using Interfaces = Ex04.Menus.Interfaces;
using Events = Ex04.Menus.Events;


namespace Ex04.Menus.Test
{
	public class MockMenus
	{
		private readonly Interfaces.MainMenu r_InterfacesMainMenu = new Interfaces.MainMenu();
		private Interfaces.Option m_InterfacesDateTimeMenu;
		private Interfaces.Option m_InterfacesVersionCapitalsMenu;

		private readonly Events.MainMenu r_EventsMainMenu = new Events.MainMenu();
		private Events.Option m_EventsDateTimeMenu;
		private Events.Option m_EventsVersionCapitalsMenu;

		public MockMenus()
		{
			createInterfacesMainMenu();
			createEventsMainMenu();
		}

		private void createInterfacesMainMenu()
		{
			m_InterfacesDateTimeMenu = new Interfaces.Option(r_InterfacesMainMenu.InitialMenu, "Show current Date/Time");
			m_InterfacesDateTimeMenu.AddOption(new Interfaces.Option(m_InterfacesDateTimeMenu, "Show current Time",new TimePresentor()));
			m_InterfacesDateTimeMenu.AddOption(new Interfaces.Option(m_InterfacesDateTimeMenu, "Show current Date", new DatePresentor()));

			m_InterfacesVersionCapitalsMenu = new Interfaces.Option(r_InterfacesMainMenu.InitialMenu, "Version and Capitals");
			m_InterfacesVersionCapitalsMenu.AddOption(new Interfaces.Option(m_InterfacesVersionCapitalsMenu, "Count Capitals", new CapitalsCounter()));
			m_InterfacesVersionCapitalsMenu.AddOption(new Interfaces.Option(m_InterfacesVersionCapitalsMenu, "Show Version", new VersionPresentor()));

			r_InterfacesMainMenu.InitialMenu.AddOption(m_InterfacesDateTimeMenu);
			r_InterfacesMainMenu.InitialMenu.AddOption(m_InterfacesVersionCapitalsMenu);
		}

		private void createEventsMainMenu()
		{
			m_EventsDateTimeMenu = new Events.Option(r_EventsMainMenu.InitialMenu, "Show current Date/Time");
			m_EventsDateTimeMenu.AddOption(new Events.Option(m_EventsDateTimeMenu, "Show current Time",new TimePresentor().Execute));
			m_EventsDateTimeMenu.AddOption(new Events.Option(m_EventsDateTimeMenu, "Show current Date", new DatePresentor().Execute));

			m_EventsVersionCapitalsMenu = new Events.Option(r_EventsMainMenu.InitialMenu, "Version and Capitals");
			m_EventsVersionCapitalsMenu.AddOption(new Events.Option(m_EventsVersionCapitalsMenu, "Count Capitals", new CapitalsCounter().Execute));
			m_EventsVersionCapitalsMenu.AddOption(new Events.Option(m_EventsVersionCapitalsMenu, "Show Version", new VersionPresentor().Execute));

			r_EventsMainMenu.InitialMenu.AddOption(m_EventsDateTimeMenu);
			r_EventsMainMenu.InitialMenu.AddOption(m_EventsVersionCapitalsMenu);		
		}
		
		public void Show()
		{
			r_InterfacesMainMenu.Show();
			r_EventsMainMenu.Show();
		}
	}
}