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
	public partial class DetailPage : ContentPage
	{
        int advertId = 0;

		public DetailPage (Advert advert)
		{
			InitializeComponent ();

            advertId = advert.Id;

            lblTitle.Text = advert.Name;
            lblDate.Text = advert.Date;
            lblDes.Text = advert.Des;

            lblUser.Text = DivarServices.GetUserMobile(advert.UserId).ToString();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GalleryPage(advertId));
        }
    }
}