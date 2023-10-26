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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void CounterButtonClick(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CountPage());
            //this.Navigation.PushModalAsync(new CountPage());
        }

        private void TabVoitureButtonClick(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }
    }
}