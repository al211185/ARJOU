using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARJOU_V001.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

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

        [Required]
        [Display(Name = "Imagen de referencia")]
        public string ImagenReferencia { get; set; }  // Almacena el nombre del archivo subido por el cliente

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
        // Configuración de la clave foránea para AspNetUsers.Id
        public string UserId { get; set; } // Clave foránea para AspNetUsers

        public bool ConfirmadoPorUsuario { get; set; } = false;
    }
}
