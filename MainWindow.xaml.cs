using System.Configuration;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EQUIX
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			MainFrame.Navigate(new HomePage()); // Start with HomePage by default
		}

		private void Navigate_Click(object sender, RoutedEventArgs e)
		{
			var button = sender as Button;
			switch (button.Tag.ToString())
			{
				case "HomePage":
					MainFrame.Navigate(new HomePage());
					break;
				case "AccountPage":
					MainFrame.Navigate(new AccountPage());
					break;
				case "TradingPage":
					MainFrame.Navigate(new TradingPage());
					break;
				case "BacktestingPage":
					MainFrame.Navigate(new BacktestingPage());
					break;
				case "SettingsPage":
					MainFrame.Navigate(new SettingsPage());
					break;
				case "CommunityPage":
					MainFrame.Navigate(new CommunityPage());
					break;
				case "PortfolioPage":
					MainFrame.Navigate(new PortfolioPage());
					break;
			}
		}

		private void CloseMainWindow(object sender, RoutedEventArgs e)
		{
			EQ.Close();
		}
	}
}
