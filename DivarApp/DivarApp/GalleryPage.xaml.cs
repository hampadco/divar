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
	public partial class GalleryPage : ContentPage
	{
        int advertId = 0;

		public GalleryPage (int id)
		{
			InitializeComponent ();

            advertId = id;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var galleries = await DivarServices.Getproduct();

            BindingContext = galleries;
        }

        public class ExtScrollView : ScrollView
        {
            protected override void LayoutChildren(double x, double y, double width, double height)
            {
                this.Content.HeightRequest = height;
                base.LayoutChildren(x, y, width, height);
            }
        }
    }
}