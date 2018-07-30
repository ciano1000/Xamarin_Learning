using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Learning.Exercises.Lists;
using Xamarin_Learning.Navigation;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Xamarin_Learning
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            /* MainPage = new NavigationPage(new WelcomePage_01()) { BarBackgroundColor = Color.Gray,
             BarTextColor = Color.White};*/

            MainPage = new NavigationPage(new ContactsPage());
            
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
