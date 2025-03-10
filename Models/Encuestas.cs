using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esthiber_Valentin_P2_AP1.Models
{
    public class Encuestas
    {
        [Key]
        public int EncuestaId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nombre de la asignatura requerido.")]
        public string Asignatura { get; set; }

        [Required(ErrorMessage = "La Fecha es requerida.")]
        public DateTime Fecha { get; set; }

        [InverseProperty("Encuesta")]
        public virtual ICollection<DetailsEncuestasCiudades> DetailsEncuestas { get; set; }

    }
}
