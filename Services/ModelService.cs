using Esthiber_Valentin_P2_AP1.Models;
using Esthiber_Valentin_P2_AP1.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Esthiber_Valentin_P2_AP1.Services
{
    public class ModelService(IDbContextFactory<Context> Dbfactory)
    {
        public async Task<bool> Insertar(Model model)
        {
            return false;
        }

        public async Task<bool> Modificar(Model model)
        {
            return false;
        }

        public async Task<bool> Guardar(Model model)
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

        public async Task<List<Model>> Listar(Expression<Func<Model, bool>> criterio)
        {
            return new();
        }
    }
}
