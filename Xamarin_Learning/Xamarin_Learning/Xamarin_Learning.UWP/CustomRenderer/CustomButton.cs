using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Xamarin_Learning.UWP.CustomRenderer;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(CustomButton))]
namespace Xamarin_Learning.UWP.CustomRenderer
{
    class CustomButton:ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            var button = e.NewElement;

            if(Control != null)
            {
                button.SizeChanged += OnSizeChanged;
            }
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            var button = (Xamarin.Forms.Button)sender;
            var color = button.BackgroundColor;

            Control.ApplyTemplate();
            var borders = Control.GetVisuals<Border>();

            foreach(var border in borders)
            {
                border.CornerRadius = new CornerRadius(button.CornerRadius);
                border.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(
            (byte)(color.A * 255), (byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255)));
            }
            button.SizeChanged -= OnSizeChanged;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "BorderRadius")
            {
                var borders = Control.GetVisuals<Border>();

                foreach (var border in borders)
                {
                    border.CornerRadius = new CornerRadius(((Xamarin.Forms.Button)sender).CornerRadius);
                }
            }
        }
    }
    static class DependencyObjectExtensions
    {
        public static IEnumerable<T> GetVisuals<T>(this DependencyObject root)
            where T : DependencyObject
        {
            int count = VisualTreeHelper.GetChildrenCount(root);

            for (int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(root, i);

                if (child is T)
                    yield return child as T;

                foreach (var descendants in child.GetVisuals<T>())
                {
                    yield return descendants;
                }
            }
        }
    }
}
