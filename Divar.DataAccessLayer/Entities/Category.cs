using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Divar.DataAccessLayer.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Parent")]
        public int? ParentId { get; set; }

        [Display(Name = "نام دسته")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نمی تواند بیش تر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        public virtual Category Parent { get; set; }

        public virtual ICollection<Advert> Adverts { get; set; }

        public virtual ICollection<CategoryField> CategoryFields { get; set; }
    }
}
