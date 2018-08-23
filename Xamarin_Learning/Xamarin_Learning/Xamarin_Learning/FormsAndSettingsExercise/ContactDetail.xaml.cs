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
	public partial class ContactDetail : ContentPage
	{
        public event EventHandler<Contact> ContactSaved;

        private ContactService contactService;
        private int _id;
        private Contact contact;
		public ContactDetail (int id)
		{
			InitializeComponent ();
            contactService = new ContactService();
            if(id !=0)
            {
                contact = contactService.GetContact(id);
                BindingContext = contact;               
            }
            else
            {
                contact = new Contact();
            }
            _id = id;
        }
       async void Handle_Saved(object sender, EventArgs args)
        {
           
                contact.Blocked = blocked.IsToggled;
                contact.FirstName = firstName.Text;
                contact.LastName = lastName.Text;
                contact.Email = email.Text;
                contact.Phone = phone.Text;
            
            if (ContactSaved != null)
                ContactSaved(sender,contact);

           await  Navigation.PopAsync();
        }
	}
}