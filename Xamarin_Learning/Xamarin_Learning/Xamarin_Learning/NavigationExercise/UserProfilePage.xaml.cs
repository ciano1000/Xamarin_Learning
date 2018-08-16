using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning.NavigationExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserProfilePage : ContentPage
	{
		public UserProfilePage (int id)
		{

			InitializeComponent ();
            UserService userService = new UserService();
            var user = userService.GetUser(id);

            BindingContext = user;
        }
	}
}