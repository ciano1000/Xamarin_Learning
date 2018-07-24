using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_Learning.Models;

namespace Xamarin_Learning
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage_01 : ContentPage
	{
        private ObservableCollection<ContactGroup> _contacts;
		public ListPage_01 ()
		{
			InitializeComponent ();

            _contacts = new ObservableCollection<ContactGroup>
            {
                new ContactGroup("C", "C")
                {
                     new Contact {Name = "Cian",ImageUrl ="http://lorempixel.com/100/100/people/1"}
                },
                new ContactGroup("G", "G")
                {
                    new Contact {Name = "Gearóid",ImageUrl ="http://lorempixel.com/100/100/people/2",Status = "Hey lets talk!"}
                }
                

            };
            listView.ItemsSource = _contacts;
		}

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e) //to disable selection set listView.SelectedItem = null;
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected",contact.Name,"OK");
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menu = sender as MenuItem;
            var contact = menu.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "ok");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            char firstLetter = contact.Name[0];
            char.ToUpper(firstLetter);
           
            var contactGroup = _contacts.Single(i => i.Title == firstLetter.ToString());


            contactGroup.Remove(contact);
            DisplayAlert("Deleted",contactGroup.Title , "ok");
        }
    }
}