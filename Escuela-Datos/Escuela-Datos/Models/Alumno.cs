using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Escuela_Datos.Models
{
    public class Alumno
    {

        [Key]
       
        [Display(Name = "IdAlumno")]
        public int IdAlumno { get; set; }

        [Required]
        [Display(Name = "NombreA")]
        public String NombreA { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public String Apellido { get; set; }

        [Required]
        [Display(Name = "Correo")]
        [MaxLength(100)]
        public String Correo { get; set; }

        public int IdEscuela { get; set; }

        [ForeignKey("IdEscuela")]
        
        public virtual Escuela? Escuela { get; private set; }
    }
}
