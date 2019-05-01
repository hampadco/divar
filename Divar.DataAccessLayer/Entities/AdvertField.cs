using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Divar.DataAccessLayer.Entities
{
    public class AdvertField
    {
        [Key]
        public int Id { get; set; }

        public int AdvertId { get; set; }

        public int FieldId { get; set; }

        [Display(Name = "مقدار")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نمی تواند بیش تر از {1} کاراکتر باشد")]
        public string FieldValue { get; set; }

        [ForeignKey("AdvertId")]
        public virtual Advert Advert { get; set; }

        [ForeignKey("FieldId")]
        public virtual Field Field { get; set; }
    }
}
