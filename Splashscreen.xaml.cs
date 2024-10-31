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
		private readonly string[] _backgroundImages = { "./Images/spacex1.jpg", "./Images/spacex2.jpg" }; // Paths to your images
		private DispatcherTimer _timer;
		private int _progressValue = 0;

		public SplashScreen()
		{
			InitializeComponent();
			InitializeSplashScreen();
		}

		private void InitializeSplashScreen()
		{
			// Randomly select an image for the background
			SetRandomBackgroundImage();

			// Initialize and start the progress bar timer
			_timer = new DispatcherTimer();
			_timer.Interval = TimeSpan.FromMilliseconds(50); // Adjust speed of progress
			_timer.Tick += Timer_Tick;
			_timer.Start();
		}

		private void SetRandomBackgroundImage()
		{
			// Randomly pick one of the background images
			Random random = new Random();
			string selectedImage = _backgroundImages[random.Next(_backgroundImages.Length)];

			// Set the background image
			string imageUri = "pack://application:,,,/EQUIX;component/" + selectedImage;
			// BackgroundImage.Source = new BitmapImage(new Uri(imageUri));

		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			_progressValue += 5; // Increment progress value
			ProgressBar.Value = _progressValue; // Update the progress bar

			if (_progressValue >= 100) // Once progress is complete
			{
				_timer.Stop();
				NavigateToLoginPage();
			}
		}

		private async void NavigateToLoginPage()
		{
			// Optionally, add a small delay for smooth transition
			await Task.Delay(500);

			// Open the main window page and close the splash screen
			MainWindow dashboard = new MainWindow();
			dashboard.Show();
			this.Close();
		}
	}
}