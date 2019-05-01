using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Divar.DataAccessLayer.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام شهر")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [MaxLength(100, ErrorMessage = "نباید بیش تر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        public virtual ICollection<Advert> Adverts { get; set; }
    }
}
