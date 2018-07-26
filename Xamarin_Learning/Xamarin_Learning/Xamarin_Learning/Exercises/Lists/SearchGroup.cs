using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Xamarin_Learning.Exercises.Lists
{
	// I've derived SearchGroup from ObservableCollection instead of List, because
	// this is the object that we'll bind the ListView to. So, when we remove
	// a Search from SearchGroup, we want the ListView to be notified. 
	public class SearchGroup : ObservableCollection<Search>
	{
		public string Title { get; set; }

		public SearchGroup(string title, IEnumerable<Search> searches = null)
            : base(searches) //creates an Observable collection that contains the elements passed into the SearchGroup Constructor e.g the searches our search group will contain
        {
			Title = title;
		}
	}
}
