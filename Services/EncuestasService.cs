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
            return false;
        }

        public async Task<bool> Modificar(Encuestas encuesta)
        {
            return false;
        }

        public async Task<bool> Guardar(Encuestas encuesta)
        {
            return false;
        }

        public async Task<bool> Eliminar(int id)
        {
            return false;
        }
        public async Task<bool> Buscar(int id)
        {
            return false;
        }

        public async Task<List<Encuestas>> Listar(Expression<Func<Encuestas, bool>> criterio)
        {
            return new();
        }
    }
}
