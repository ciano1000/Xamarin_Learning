using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Learning.FormsAndSettingsExercise
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }

        public bool Blocked { get; set; } = false;
        public int Id { get; set; }

        private static int _Counter = 0;

        public Contact()
        {
            this.Id = System.Threading.Interlocked.Increment(ref _Counter);
        }
    }
}
