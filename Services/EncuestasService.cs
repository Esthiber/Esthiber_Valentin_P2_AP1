using Esthiber_Valentin_P2_AP1.DAL;
using Esthiber_Valentin_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Esthiber_Valentin_P2_AP1.Services
{
    public class EncuestasService(IDbContextFactory<Context> Dbfactory)
    {
        public async Task<bool> Insertar(Encuestas encuesta)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            context.Encuestas.Add(encuesta);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Modificar(Encuestas encuesta)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            context.Encuestas.Update(encuesta);
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Guardar(Encuestas encuesta)
        {
            if (!await Existe(encuesta.EncuestaId))
            {
                return await Insertar(encuesta);
            }
            else
            {
                return await Modificar(encuesta);
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            return await context.Encuestas
                .Where(e => e.EncuestaId == id)
                .ExecuteDeleteAsync() > 0;
        }
        
        public async Task<bool> Existe(int id)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            return await context.Encuestas.AnyAsync(e => e.EncuestaId == id);
        }


        public async Task<Encuestas> Buscar(int id)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            return await context.Encuestas
                .FirstOrDefaultAsync(e => e.EncuestaId == id) ?? null!;
        }
        public async Task<List<Encuestas>> Listar(Expression<Func<Encuestas, bool>> criterio)
        {
            await using var context = await Dbfactory.CreateDbContextAsync();
            return await context.Encuestas
                .Where(criterio)
                .ToListAsync();
        }
    }
}
