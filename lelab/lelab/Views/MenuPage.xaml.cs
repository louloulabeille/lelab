using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void ListPageButtonClick(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new ListPage());
        }

        private void Forms_3_5ButtonClick(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Form_3_5_Page());
        }
    }
}