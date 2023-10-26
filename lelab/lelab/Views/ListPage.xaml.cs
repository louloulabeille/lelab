using lelab.Models;
using lelab.ViewModels;
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
	public partial class ListPage : ContentPage
	{
		private List<ArticleViewModel> _articles = new List<ArticleViewModel>();


		public ListPage()
		{
			InitializeComponent();

			_articles.Add(new ArticleViewModel() { Nom = "Lait", Prix = 1.05, Description = "Lait de vache UHT" });
			_articles.Add(new ArticleViewModel() { Nom = "Bordeaux", Prix = 22.00, Description="Vin de Bordeaux sans eau." });
            _articles.Add(new ArticleViewModel() { Nom = "Eau", Prix = 0.72, Description="Eau de source 1 litre." });

            InitListeArticleView();
            listePage.ItemSelected += SelectItemsListeArticleHandler;
        }

        private void SelectItemsListeArticleHandler(object sender, EventArgs e)
        {
            if ( listePage.SelectedItem != null)
            {
                var item = listePage.SelectedItem as ArticleViewModel;
                DisplayAlert($"{ item.Nom}", $"Prix {item.Prix} €\n{item.Description}", "OK");
                listePage.SelectedItem = null;
            }
            
        }

        private void InitListeArticleView()
        {
            listePage.ItemsSource = _articles;
            listePage.ItemTemplate = new DataTemplate(() => {
                Label nomArticle = new Label();
                nomArticle.SetBinding(Label.TextProperty, "Nom");
                nomArticle.Margin = new Thickness(5, 0, 0, 0);
                nomArticle.HorizontalOptions = LayoutOptions.StartAndExpand;
                nomArticle.TextColor = Color.Black;

                Label prixArticle = new Label();
                prixArticle.SetBinding(Label.TextProperty,
                    new Binding("Prix", BindingMode.OneWay,
                        null, null, "{0} €"));
                prixArticle.Margin = new Thickness(0, 0, 5, 0);
                prixArticle.HorizontalOptions = LayoutOptions.EndAndExpand;
                prixArticle.TextColor = Color.Black;

                // Return an assembled ViewCell.
                return new ViewCell
                {
                    View = new StackLayout
                    {
                        Padding = new Thickness(0, 5),
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children =
                                {
                                    nomArticle,
                                    prixArticle
                                }
                    }
                };
            });
        }


	}
}