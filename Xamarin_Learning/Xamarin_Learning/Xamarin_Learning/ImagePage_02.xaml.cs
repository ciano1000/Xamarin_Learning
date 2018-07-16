using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage_02 : ContentPage
	{
		public ImagePage_02 ()
		{
			InitializeComponent ();
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    image.Source = ImageSource.FromResource("Xamarin_Learning.Android.Images.background.jpg");
                        break;
                case Device.UWP:
                    image.Source = ImageSource.FromResource("Xamarin_Learning.UWP.Images.background.jpg",Assembly.GetExecutingAssembly());
                    break;
            }
           // image.Source = ImageSource.FromResource("Xamarin_Learning.UWP.Images.background.jpg",Assembly.GetExecutingAssembly());
		}
	}
}