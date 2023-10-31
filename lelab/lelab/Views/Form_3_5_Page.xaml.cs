using lelab.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lelab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Form_3_5_Page : ContentPage
	{
        // cela ne marche plus en > 5 version de xamarin
        /*public ICommand ClickCommand = new Command<string>((url) =>
        {
            Console.WriteLine(url);
            //Device.OpenUri(new Uri(url));
            Launcher.OpenAsync(new Uri(url));
        });*/

        public Forms_3_5ViewsModel ModelView = new Forms_3_5ViewsModel();

        public Form_3_5_Page ()
		{
			InitializeComponent ();
            //ClickImageButton.Clicked += ImageButton_Clicked

            ModelView.ClickCommand = new Command<string>((url) => {
                //Launcher.OpenAsync (url);
                this.Navigation.PushAsync(new WebViewPage(url));
            });
            BindingContext = ModelView;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
			//await ClickImageButton.ScaleTo(0.8, 250);
			Console.WriteLine("Clic - clic");
            //ClickImageButton.ScaleTo(1, 500);
            //await ClickImageButton.ScaleTo(1, 250);
        }

        
    }
}