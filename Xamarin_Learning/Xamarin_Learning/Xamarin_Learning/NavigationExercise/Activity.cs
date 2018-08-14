using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_Learning.NavigationExercise
{
    class Activity
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public string ImageUrl
        {
            get
            {
                return String.Format("http://lorempixel.com/100/100/people/{0}", UserId);
            }
        }
    }
}
