using Esthiber_Valentin_P2_AP1.DAL;
using Microsoft.EntityFrameworkCore;

namespace Esthiber_Valentin_P2_AP1.Services
{
    public class CiudadesService(IDbContextFactory<Context> Dbfactory)
    {
        public enum TipoOperacion
        {
            Sumar,
            Restar
        }

        public async Task<bool> UpdateMonto(int id, double monto, TipoOperacion tipoOperacion)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            if (tipoOperacion == TipoOperacion.Sumar)
            {

            }

            if (tipoOperacion == TipoOperacion.Restar)
            {

            }

            return false;
        }
    }
}
