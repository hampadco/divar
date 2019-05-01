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
	public partial class CityPage : ContentPage
	{
		public CityPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var cities = await DivarServices.GetCitiesAsync();

            BindingContext = cities;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
          
                City c = e.Item as City;

                Navigation.PushAsync(new CityAdvertsPage(c.Id));
           
        }
    }
}