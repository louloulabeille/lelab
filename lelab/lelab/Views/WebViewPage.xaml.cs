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
	public partial class WebViewPage : ContentPage
	{
		private readonly string _url;
		public WebViewPage (string url)
		{
			InitializeComponent ();
			_url = url;

            ChargeWebView.Source = _url;

        }
	}
}