using System.ComponentModel.DataAnnotations;

namespace IntroAsp.Models.ViewModels
{
    public class BeerViewModels
    {
        [Required]
        [Display(Name="Name")]
        public string Nombre {  get; set; }

        [Required]
        [Display(Name="Marca")]
        public int IdBrand {  get; set; }
    }
}
