using System.ComponentModel.DataAnnotations;

namespace Esthiber_Valentin_P2_AP1.Models
{
    public class DetailsEncuestasCiudades
    {
        [Key]
        public int DetailsEncuestasCiudadesId { get; set; }

        public int EncuestaId { get; set; }

        public int CuidadId { get; set; }

        public virtual Encuestas Encuesta { get; set; } = null!;

        public virtual Ciudades Ciudad { get; set; } = null!;
    }
}
