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
	public partial class ImageExercise : ContentPage
	{

         string[] images = new string[] {"http://hd.wallpaperswide.com/thumbs/idyllic_landscape_italy-t2.jpg",
         "http://wallpoper.com/images/00/44/98/44/landscape-in-argentina_00449844.jpg","http://www.baltana.com/files/wallpapers-1/Landscapes-1920X1080-Space-Wallpaper-03092.jpg",
         "http://wallpoper.com/images/00/40/08/45/landscapes-dock_00400845.jpg"};
        int currentImage = 0;
        public ImageExercise ()
		{
			InitializeComponent ();

            image.Source = images[0];
            
		}

        private void Left_Button_Clicked(object sender, EventArgs e)
        {
            if(currentImage == 0)
            {
                currentImage = 3;
            }
            else
            {
                currentImage -= 1;
            }
            image.Source = images[currentImage];
        }

        private void Right_Button_Clicked(object sender, EventArgs e)
        {
            if(currentImage == 3)
            {
                currentImage = 0;
            }
            else
            {
                currentImage += 1;
            }
            image.Source = images[currentImage];
        }
    }
}