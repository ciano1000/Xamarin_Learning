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
	public partial class Activities : ContentPage
	{
		public Activities ()
		{
            InitializeComponent();
            ActivityService activityService = new ActivityService();
            listView.ItemsSource = activityService.GetActivities();
		}

        async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var item = e.SelectedItem as Activity;
            await Navigation.PushAsync(new UserProfilePage(item.UserId));
            listView.SelectedItem = null;
        }
    }
}