using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Divar.DataAccessLayer.Entities
{
    public class Advert
    {
        [Key]
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int UserId { get; set; }

        [Display(Name = "عنوان آگهی")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نمی تواند بیش تر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Des { get; set; }

        [Display(Name = "تاریخ ایجاد")]
        [MaxLength(10, ErrorMessage = "مقدار {0} نمی تواند بیش تر از {1} کاراکتر باشد")]
        public string Date { get; set; }

        [Display(Name = "بازدید")]
        public int Seen { get; set; }

        [Display(Name = "منقضی")]
        public bool IsExpire { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<AdvertField> AdvertFields { get; set; }

        public virtual ICollection<Gallery> Galleries { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City City { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
