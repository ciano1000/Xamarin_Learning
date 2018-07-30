using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomePage_01 : ContentPage
	{
		public WelcomePage_01 ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IntroductionPage_01());//replace with PushModalAsync to get a "modal" page that pops out of the bottom of screen, used for compulsory forms etc
        }
    }
}