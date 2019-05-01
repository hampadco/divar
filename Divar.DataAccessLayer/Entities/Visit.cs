using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Divar.DataAccessLayer.Entities
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        public int AdvertId { get; set; }

        [Display(Name = "آی پی کاربر")]
        [MaxLength(20, ErrorMessage = "نباید بیش تر از {1} کاراکتر باشد")]
        public string AddressIP { get; set; }

        [Display(Name = "ساعت بازدید")]
        [MaxLength(10, ErrorMessage = "نباید بیش تر از {1} کاراکتر باشد")]
        public string VisitTime { get; set; }

        [Display(Name = "تاریخ بازدید")]
        [MaxLength(10, ErrorMessage = "نباید بیش تر از {1} کاراکتر باشد")]
        public string VisitDate { get; set; }

        [ForeignKey("AdvertId")]
        public virtual Advert Advert { get; set; }
    }
}
