using System;
using System.Collections.Generic;
using System.Text;

namespace DivarApp.Models
{
    public class Gallery
    {
        public int Id { get; set; }

        public int AdvertId { get; set; }

        public string Img { get; set; }

        public Uri ImgUri
        {
            get { return string.IsNullOrEmpty(Img) ? null : new Uri("http://192.168.1.50:5461/images/adverts/"+Img); }
        }
    }
}
