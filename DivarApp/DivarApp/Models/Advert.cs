using System;
using System.Collections.Generic;
using System.Text;

namespace DivarApp.Models
{
    public class Advert
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Des { get; set; }

        public string Date { get; set; }
    }
}
