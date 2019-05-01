using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Divar.DataAccessLayer.Entities
{
   public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Category { get; set; }

        public string namep { get; set; }
        public int price { get; set; }
        public string patimg { get; set; }
        public int stait { get; set; }
    }
}
