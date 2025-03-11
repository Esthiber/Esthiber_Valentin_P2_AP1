using Esthiber_Valentin_P2_AP1.DAL;
using Esthiber_Valentin_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public async Task<List<Ciudades>> Listar(Expression<Func<Ciudades, bool>> criterio)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            return await context.Ciudades
                .Where(criterio)
                .ToListAsync();
        }
    }
}
