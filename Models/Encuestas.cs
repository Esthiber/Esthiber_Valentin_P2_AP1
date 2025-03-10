using System.ComponentModel.DataAnnotations;

namespace Esthiber_Valentin_P2_AP1.Models
{
    public class Encuestas
    {
        [Key]
        public int EncuestaId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nombre de la asignatura requerido.")]
        public string Asignatura { get; set; }

    }
}
