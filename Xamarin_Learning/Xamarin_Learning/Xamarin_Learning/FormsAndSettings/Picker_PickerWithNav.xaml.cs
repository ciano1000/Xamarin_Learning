﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning.FormsAndSettings
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Picker_PickerWithNav : ContentPage
	{
		public Picker_PickerWithNav ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<string>
            {
                "None","Email","SMS"
            };

		}

        public ListView ContactMethods { get { return listView; } }

	}
}