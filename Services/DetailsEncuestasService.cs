using Esthiber_Valentin_P2_AP1.DAL;
using Esthiber_Valentin_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Esthiber_Valentin_P2_AP1.Services
{
    public class DetailsEncuestasService(IDbContextFactory<Context> Dbfactory)
    {
        public async Task<bool> Insertar(DetailsEncuestasCiudades details)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            context.DetailsEncuestas.Add(details);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(DetailsEncuestasCiudades details)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            context.DetailsEncuestas.Update(details);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Guardar(DetailsEncuestasCiudades details)
        {
            return false;
        }

        public async Task<bool> Eliminar(int id)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            return await context.DetailsEncuestas
                .Where(d => d.DetailsEncuestasCiudadesId == id)
                .ExecuteDeleteAsync() > 0;
        }

        public async Task<List<DetailsEncuestasCiudades>> Listar(Expression<Func<DetailsEncuestasCiudades, bool>> criterio)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            return new();
        }
    }
}
