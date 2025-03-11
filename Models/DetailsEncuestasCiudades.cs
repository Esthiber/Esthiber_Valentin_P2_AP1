using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esthiber_Valentin_P2_AP1.Models
{
    public class DetailsEncuestasCiudades
    {
        [Key]
        public int DetailsEncuestasCiudadesId { get; set; }

        public int EncuestaId { get; set; }

        [Required(ErrorMessage = "La ciudad es requerida.")]
        public int CiudadId { get; set; }

        [Required(ErrorMessage = "El monto es requerido.")]
        [Range(0.01, 500000, ErrorMessage = "El monto debe ser mayor a 0 y menor a 500,000")]
        public double Monto { get; set; } = 0;

        [ForeignKey("EncuestaId")]
        [InverseProperty("DetailsEncuestas")]
        public virtual Encuestas Encuesta { get; set; } = null!;

        [ForeignKey("CuidadId")]
        public virtual Ciudades Ciudad { get; set; } = null!;
    }
}
