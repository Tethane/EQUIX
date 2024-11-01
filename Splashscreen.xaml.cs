using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace EQUIX
{
	/// <summary>
	/// Interaction logic for Splashscreen.xaml
	/// </summary>
	public partial class SplashScreen : Window
	{
		private readonly string[] _backgroundImages = { "./Images/spacex1.jpg", "./Images/spacex2.jpg" };
		private DispatcherTimer _timer;
		private int _progressValue = 0;

		public SplashScreen()
		{
			InitializeComponent();
			InitializeSplashScreen();
		}

		private void InitializeSplashScreen()
		{
			_timer = new DispatcherTimer();
			_timer.Interval = TimeSpan.FromMilliseconds(50); 
			_timer.Tick += Timer_Tick;
			_timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			_progressValue += 5;
			ProgressBar.Value = _progressValue; 

			if (_progressValue >= 100)
			{
				_timer.Stop();
				NavigateToLoginPage();
			}
		}

		private async void NavigateToLoginPage()
		{
			await Task.Delay(500);

			MainWindow dashboard = new MainWindow();
			dashboard.Show();
			this.Close();
		}
	}
}