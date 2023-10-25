using lelab.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace lelab.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}