using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning.DataAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApplicationProperties : ContentPage
	{


        public ApplicationProperties ()
		{
            
			InitializeComponent ();
            BindingContext = Application.Current;

            //loading settings, we check if the application has been run before by testing if these settings are saved in the dictionary

        }
        //all the loading and setting of the application properties is now handled by the App class propertie
       /* private void OnChange(object sender, System.EventArgs e)
        {

            var app = Application.Current as App;
            app.Title = title.Text;
            app.NotificationsEnabled = notificationsEnabled.On;//these properties are saved when the app goes to sleep mode;

            //Application.Current.SavePropertiesAsync(); forces properties to be saved immediately
        }*/
      /*  protected override void OnDisappearing() //from Page class, this method is called whenever a user navugates away from this page
        {
            base.OnDisappearing();
        }*/
    }
}