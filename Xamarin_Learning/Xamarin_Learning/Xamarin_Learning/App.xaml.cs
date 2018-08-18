using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Learning.Exercises.Lists;
using Xamarin_Learning.Navigation;
using Xamarin_Learning.NavigationExercise;
using Xamarin_Learning.FormsAndSettings;
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

            //MainPage = new NavigationPage(new ContactsPage()); for Master Detail Pages
            // MainPage = new TabbedPagesMain();
            //MainPage = new CarouselPage_01();
            // MainPage = new NavigationPage(new ToolbarItems());
            // NavigationPage navPage = new NavigationPage(new InstaPage());

            //MainPage = new TableViewPage();
            MainPage = new NavigationPage(new Main_PickerWithNav());
            
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
