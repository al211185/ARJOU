using ARJOU_V001.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARJOU_V001.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Apellido { get; set; }
        public string Rol { get; set; }
        public string Direccion { get; set; }
        // Propiedad de navegación para establecer la relación con Pedido
        public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
