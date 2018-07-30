using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Learning.Models;

namespace Xamarin_Learning.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
			InitializeComponent ();
            listView.ItemsSource = new List<Contact> {
            new Contact{Name = "Mosh", ImageUrl = "http://lorempixel.com/100/100", Status = "Online" },
            new Contact{Name = "Cian", ImageUrl = "http://lorempixel.com/100/100/2", Status = "Online" }
        };
		}

        async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }
            var contact = e.SelectedItem as Contact;
           await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }
    }
}