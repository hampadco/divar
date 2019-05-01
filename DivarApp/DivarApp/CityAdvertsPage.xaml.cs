using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using DivarApp.Models;

namespace DivarApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CityAdvertsPage : ContentPage
	{
        int cityId = 0;

		public CityAdvertsPage (int CityId)
		{
			InitializeComponent ();

            cityId = CityId;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var adverts = await DivarServices.GetAdvertsAsync(cityId);

            BindingContext = adverts;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Advert a = e.Item as Advert;

            Navigation.PushAsync(new DetailPage(a));

        }
    }
}