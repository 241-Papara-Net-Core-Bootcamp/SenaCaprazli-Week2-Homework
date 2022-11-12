using PaparaSecondWeek1.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaparaSecondWeek1.Models
{
  
    public class OwnerModel
    {
        [Key]
        [ValidateModelState]
        public int Id { get; set; }

        public string Name{ get; set; }
        [Required]
        [Description("açıklama alanı")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Tarih alanı boş geçilemez")]
        public DateTime CreateDate { get; set; }
        public ColorEnum Color { get; set; }
    }

    public enum ColorEnum
    {
        [Display(Name ="Siyah")]
        Black = 1,
        [Display(Name = "Kırmızı")]
        Red = 2,
        [Display(Name = "yeşil")]
        Green = 3,
        [Display(Name = "Mavi")]
        Blue = 4

    }
}
