using System.ComponentModel.DataAnnotations;

namespace CoreValidation_2.Models.ViewModels.PureVm.Category
{
    //PureVM
    //CategoryVM
    //CategoryRequestModel
    //CategoryResponseModel
    public class CategoryRequestModel
    {
        //DataAnnotation'da yer tutucu operatorleri sayılarla verilir...0, ilgili property neyse direkt o ismi alır...

        [Required(ErrorMessage = "{0} zorunlu bir alandır.")]
        [Display(Name = "Kategori ismi")] //Bizim property'miz kullanıcıya istediğimiz şekilde gösteriyoruz
        [MinLength(5, ErrorMessage = "{0} an az {1} karakter alabilir")]
        [MaxLength(15, ErrorMessage = "{0} en fazla {1} karakter alabilir")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "{0} zorunlu bir alandır")]
        [Display(Name = "Aciklama")]
        [MinLength(15, ErrorMessage = "{0} an az {1} karakter alabilir")]
        [MaxLength(100, ErrorMessage = "{0} en fazla {1} karakter alabilir")]
        public string Description { get; set; }

    }
}
