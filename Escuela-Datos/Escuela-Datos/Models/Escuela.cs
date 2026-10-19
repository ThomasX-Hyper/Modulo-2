using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Escuela_Datos.Models
{
    public class Escuela
    {
        [Key]
        
        [Display(Name ="IdEscuela")]
        public int IdEscuela {  get; set; }

        [Required]
        [Display(Name = "nombre")]
        public String nombre { get; set; }

        [Required]
        [Display(Name = "Ubicacion")]
        public String Ubicacion { get; set; }

        [Required]
        [Display(Name = "estado")]
        public String estado { get; set; }
        [JsonIgnore]
        public ICollection<Alumno> Alumno {  get; set; }
    }
}
