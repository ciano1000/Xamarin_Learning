using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;

using Xamarin.Forms;
using System.Reflection;

namespace Xamarin_Learning.MarkupExtensions
{
    [ContentProperty ("ResourceId")] //enables us to write path without referncing ResourceId in XAML
    class EmbeddedImage : IMarkupExtension
    {

        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider) // need to return an image source
        {
            string Namespace = this.GetType().Namespace;

            if(String.IsNullOrWhiteSpace(ResourceId))
            {
                return null;
            }
            else
            {
                switch (Device.RuntimePlatform)
                {
                    case Device.UWP:
                        return ImageSource.FromResource("Xamarin_Learning.UWP."+ResourceId,typeof(App));

                    case Device.Android:
                        return ImageSource.FromResource("Xamarin_Learning.Android." + ResourceId);

                    default:
                        return null;
                }
                
            }
           
        }
    }
}
