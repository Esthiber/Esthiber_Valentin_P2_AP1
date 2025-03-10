using System.ComponentModel.DataAnnotations;

namespace Esthiber_Valentin_P2_AP1.Models
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }
        public string Nombre { get; set; }
        public double Monto { get; set; }
    }
}
