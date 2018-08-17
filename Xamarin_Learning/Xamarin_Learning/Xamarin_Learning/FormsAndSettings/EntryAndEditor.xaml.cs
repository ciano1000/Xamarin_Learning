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
	public partial class EntryAndEditor : ContentPage
	{
		public EntryAndEditor ()
		{
			InitializeComponent ();
		}

        private void Entry_Completed(object sender, EventArgs e)
        {
            label.Text = "Completed";
        }
    }
}