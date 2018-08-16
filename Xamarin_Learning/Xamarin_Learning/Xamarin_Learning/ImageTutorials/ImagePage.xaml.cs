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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            //var imageSource = (UriImageSource)ImageSource.FromUri(new Uri("http://"));

            UriImageSource imageSource = new UriImageSource { Uri = new Uri("https://images.wallpaperscraft.com/image/chrysanthemum_flower_petals_118883_1920x1080.jpg") };
            imageSource.CachingEnabled = false; //trueif you want to cache picture
                                               // imageSource.CacheValidity = TimeSpan.FromHours(1);

            image.Source = imageSource;
            image.Aspect = Aspect.AspectFill;
        }
	}
}