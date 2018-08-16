using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage_04 : ContentPage
	{
		public ImagePage_04 ()
		{
			InitializeComponent ();
            switch (Device.RuntimePlatform)// can also do this in XAML as seen with padding example
            {
                case Device.Android:
                    btn.Image = (FileImageSource)ImageSource.FromFile("clock.png");
                    break;
                case Device.iOS:
                    btn.Image = (FileImageSource)ImageSource.FromFile("clock.png");
                    break;
                case Device.UWP:
                    btn.Image = (FileImageSource)ImageSource.FromFile("Images/clock.png");
                    break;
            }
            
		}
	}
}