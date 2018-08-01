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
	public partial class TabbedPagesMain : TabbedPage
	{
		public TabbedPagesMain ()
		{
			InitializeComponent ();

           /* this.Children.Add(new ContentPage());
            this.Children.Add(new NavigationPage(new ContentPage()));
            this.Children.Add(new ContactDetailPage());*/
        }
	}
}