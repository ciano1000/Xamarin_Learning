using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Xamarin_Learning.FormsAndSettingsExercise
{
    class ContactService
    {
        private List<Contact> _contacts = new List<Contact> { new Contact { FirstName = "Cian", LastName = "Mc Sweeney", Phone = "0858388199", Email = "ciano1000@gmail.com"},
                                          new Contact { FirstName = "John", LastName = "Mc Sweeney", Phone = "0877643002", Email = "seanpolmacsuibhne@gmail.com"}};

        public IEnumerable<Contact> GetContacts()
        {
            return _contacts;
        }
        public Contact GetContact(int id)
        {
            return _contacts.Single(x => x.Id == id);
        }
        public void DeleteContact(Contact contact)
        {
            _contacts.Remove(_contacts.Single(x=> x.Id == contact.Id));
        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        public void UpdateContact(Contact contact, bool blocked, string firstName = null,string lastName = null, string phone = null, string email = null)
        {
            var _contact = _contacts.Single(x => x.Id == contact.Id);

            if (!String.IsNullOrEmpty(firstName))
                _contact.FirstName = firstName;
            if (!String.IsNullOrEmpty(lastName))
                _contact.LastName = lastName;
            if (!String.IsNullOrEmpty(phone))
                _contact.Phone = phone;
            if (!String.IsNullOrEmpty(email))
                _contact.Email = email;
            _contact.Blocked = blocked;
        }
    }
}
