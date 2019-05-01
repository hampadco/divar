using System;
using System.Collections.Generic;
using System.Text;

namespace DivarApp.Models
{
     public class Products
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string namep { get; set; }
        public int price { get; set; }
        public string patimg { get; set; }
        public int stait { get; set; }
        public Uri ImgUri
        {
            get { return string.IsNullOrEmpty(patimg) ? null : new Uri("http://192.168.1.50:5461/" + patimg); }
        }
    }
}
