using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using Xamarin_Learning.Android.CustomRenderer;
using Android.Graphics.Drawables;
using Android.Util;
using System.ComponentModel;
using Android.Graphics;

[assembly: ExportRenderer(typeof(Button), typeof(CustomButton))]

namespace Xamarin_Learning.Android.CustomRenderer
{
    /// <summary>
    /// Overrides AppCompat problems with round buttons. Works like a charm!
    /// </summary>
    public class CustomButton : ButtonRenderer
    {
        public CustomButton(Context context):base(context)
        {

        }
        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
        }
    }
}