using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Learning
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exercise : ContentPage
	{
        public Exercise()
        {
            InitializeComponent();
            slider.Value = 16;
            label.Text = "I am a man of fortune and I must seek my fortune";
        }
        private int counter = 1;
        private void Button_Clicked(object sender, EventArgs e)
        {
            string[] quotes = new string[3];
            quotes[0] = "I am a man of fortune and I must seek my fortune";
            quotes[1] = "The dreamers of the day are dangerous men for they may live their dreams with open eyes";
            quotes[2] = "I love uncharted a bit too much lol";

            label.Text = quotes[counter];

            counter++;
            if (counter == 3)
            {
                counter = 0;
            }
        }


    }
}