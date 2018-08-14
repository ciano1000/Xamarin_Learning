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
	public partial class ToolbarItems : ContentPage
	{
		public ToolbarItems ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem Activated","Ok");
        }
    }
}