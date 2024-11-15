using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARJOU_V001.ViewModels
{
    public class PedidoVM
    {
        //7

        [Required]
        [StringLength(50)]
        [Display(Name = "Estilo Deseado")]
        public string EstiloDeseado { get; set; }  // Ejemplo: 'Rizado', 'Liso', 'Largo'

        [StringLength(100)]
        [Display(Name = "Color Deseado")]
        public string ColorDeseado { get; set; }  // Ejemplo: 'Negro', 'Rubio', 'Gris'

        [StringLength(100)]
        [Display(Name = "Longitud Deseada")]
        public string LongitudDeseada { get; set; }  // Ejemplo: 'Corta', 'Larga'

        [StringLength(500)]
        [Display(Name = "Descripción adicional")]
        public string DescripcionAdicional { get; set; }  // Ejemplo: Detalles sobre la peluca, como peinado específico o mezcla de colores
        
        
        [Display(Name = "Imagen de referencia")]
        //8
        public IFormFile Referencia { get; set; }

        [Range(0, 10000)]
        [DataType(DataType.Currency)]
        [Display(Name = "Precio estimado")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioEstimado { get; set; }  // Estimación de costo según la personalización

        [Display(Name = "Fecha de solicitud")]
        public DateTime FechaSolicitud { get; set; }

        [Display(Name = "Estado de la solicitud")]
        public string Estado { get; set; }  // Ejemplo: 'Pendiente', 'En proceso', 'Completada'

        // Relación con el usuario
        public string UserId { get; set; }
        public bool ConfirmadoPorUsuario { get; set; } = false;
    }
}
