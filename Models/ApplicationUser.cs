using Microsoft.AspNetCore.Identity;

namespace BioSportWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Campos adicionales para tu gimnasio
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
        
        // Campo para identificar el rol (ej: Administrador, Recepcionista, Entrenador, Cliente)
        public string Rol { get; set; }
    }
}