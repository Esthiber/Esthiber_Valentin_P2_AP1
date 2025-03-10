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
            var ciudad = await context.Ciudades.FirstOrDefaultAsync(c => c.CiudadId == id) ?? new();

            if (tipoOperacion == TipoOperacion.Sumar)
                ciudad.Monto += monto;

            if (tipoOperacion == TipoOperacion.Restar)
                ciudad.Monto -= monto;

            context.Ciudades.Update(ciudad);

            return await context.SaveChangesAsync() > 0;
        }
    }
}
