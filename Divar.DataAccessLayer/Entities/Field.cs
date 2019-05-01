using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Divar.DataAccessLayer.Entities
{
    public class Field
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "نام مشخصه")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نمی تواند بیش تر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [Display(Name = "مخفی در جستجو")]
        public bool HideInFilter { get; set; }

        public virtual ICollection<AdvertField> AdvertFields { get; set; }

        public virtual ICollection<CategoryField> CategoryFields { get; set; }
    }
}
