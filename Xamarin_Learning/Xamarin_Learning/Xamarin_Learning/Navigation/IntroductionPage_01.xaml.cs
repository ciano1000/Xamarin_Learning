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
	public partial class IntroductionPage_01 : ContentPage
	{
		public IntroductionPage_01 ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        /*to prevent use of the onscreen or hardware back button on android*/

       /* protected override bool OnBackButtonPressed()
        {
            return true;
        }*/
    }
}