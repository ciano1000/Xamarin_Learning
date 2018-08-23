using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning.FormsAndSettingsExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactBook : ContentPage
	{
        private ContactService contactService;
		public ContactBook ()
		{
			InitializeComponent ();
            contactService = new ContactService();
            listView.ItemsSource = contactService.GetContacts();
		}


       async private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var _contact = e.SelectedItem as Contact;
            var page = new ContactDetail(_contact.Id);
              page.ContactSaved += (source, contact) =>
              {
                  contactService.AddContact(contact);
                  contactService.DeleteContact(_contact);
              };
            await Navigation.PushAsync(page);
        }
    }
}