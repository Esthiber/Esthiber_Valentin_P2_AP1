using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Esthiber_Valentin_P2_AP1.Models
{
    public class DetailsEncuestasCiudades
    {
        [Key]
        public int DetailsEncuestasCiudadesId { get; set; }

        public int EncuestaId { get; set; }

        public int CuidadId { get; set; }

        [ForeignKey("EncuestaId")]
        [InverseProperty("DetailsEncuestas")]
        public virtual Encuestas Encuesta { get; set; } = null!;

        [ForeignKey("CiudadId")]
        public virtual Ciudades Ciudad { get; set; } = null!;
    }
}
