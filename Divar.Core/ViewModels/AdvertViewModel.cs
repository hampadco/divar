using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace Divar.Core.ViewModels
{
    public class AdvertViewModel
    {
        [Display(Name = "عنوان آگهی")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نمی تواند بیش تر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Des { get; set; }

        public int CityId { get; set; }
    }

    public class EditAdvertViewModel
    {
        [Display(Name = "عنوان آگهی")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "مقدار {0} نمی تواند بیش تر از {1} کاراکتر باشد")]
        public string Name { get; set; }

        [Display(Name = "توضیحات")]
        [DataType(DataType.MultilineText)]
        public string Des { get; set; }

        [Display(Name = "منقضی")]
        public bool IsExpire { get; set; }
    }

    public class AddAdvertFieldViewModel
    {
        [Display(Name = "انتخاب ویژگی")]
        public int FieldId { get; set; }

        [Display(Name = "مقدار ویژگی")]
        [Required(ErrorMessage = "مقدار {0} را وارد کنید")]
        public string Value { get; set; }
    }

    public class AddGalleryViewModel
    {
        [Display(Name = "انتخاب تصویر")]
        public IFormFile Img { get; set; }

        public string ImgName { get; set; }
    }
}
