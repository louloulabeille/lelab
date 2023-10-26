using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabAvion : ContentPage
	{
		public TabAvion ()
		{
			InitializeComponent ();
			avionImage.Opacity = 0;
		}

        protected override void OnAppearing()
        {
            uint timeLength = 800;

            base.OnAppearing();

            avionImage.TranslationX = -250;
			avionImage.TranslationY = -150;
			avionImage.Rotation = 45;
			avionImage.Scale = 0.7;
			avionImage.Opacity = 0;
			// translation
			avionImage.FadeTo(1, 100);
			avionImage.TranslateTo(0, 0, timeLength, Easing.SinOut);
			avionImage.RotateTo(0, timeLength, Easing.SinOut);
			avionImage.ScaleTo(1,timeLength,Easing.SinOut);

        }
    }
}