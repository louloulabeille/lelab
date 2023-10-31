using lelab.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace lelab.ViewModels
{
    public class Forms_3_5ViewsModel : BaseViewModel
    {
        public ICommand ClickCommand { get; set; }

        public Forms_3_5ViewsModel() {
            //ClickCommand = new Command<string>(ChargeUrl);
        }


/*        private async void ChargeUrl(string url)
        {
            //await Shell.Current.GoToAsync($"//WebViewPage");
            //await Shell.Current.GoToAsync("//LoginPage");
        }
*/
    }
}
