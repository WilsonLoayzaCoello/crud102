using System.ComponentModel.DataAnnotations;

namespace _102Novadoc.Data.Entities
{
    public class Producto
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string? Name { get; set; }
        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int Price { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public int? Stock { get; set; }

        [Display(Name = "Categoría")]
        [MaxLength(3, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string? Category { get; set; }
        [Display(Name = "Imagen")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Descripción")]
        public string? Description { get; set; }
        [Display(Name = "Fecha de creación")]
        public DateTime? CreatedAt { get; set; }
    }
}
