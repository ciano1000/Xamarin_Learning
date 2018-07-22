using System;
using System.Collections.Generic;
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
		public ListPage_01 ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<ContactGroup>
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
		}
	}
}