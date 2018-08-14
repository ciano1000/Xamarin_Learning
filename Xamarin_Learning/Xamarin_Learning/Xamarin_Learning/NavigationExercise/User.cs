using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Learning.NavigationExercise
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            get
            {
                return String.Format("http://lorempixel.com/100/100/people/{0}", Id);
            }
        }
    }
}
