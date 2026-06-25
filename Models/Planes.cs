using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BioSportWeb.Models
{
    [Table("Planes")]
    public class Planes
    {
        [Key]
        [Column("id_plan")]
        public int IdPlan { get; set; }
        
        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;
        
        [Column("precio")]
        public decimal Precio { get; set; }
        
        [Column("duracion_dias")]
        public int DuracionDias { get; set; }
    }
}