using System.Configuration;
using System.Data;
using System.IO;
using System.Reflection;
using System.Windows;


namespace EQUIX
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			SplashScreen splashScreen = new SplashScreen();
			splashScreen.Show();
		}
	}

}
