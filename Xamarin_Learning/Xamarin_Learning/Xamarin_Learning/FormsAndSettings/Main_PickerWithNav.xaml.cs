using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning.FormsAndSettings
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main_PickerWithNav : ContentPage
	{
		public Main_PickerWithNav ()
		{
			InitializeComponent ();
		}

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new Picker_PickerWithNav();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }
    }
}