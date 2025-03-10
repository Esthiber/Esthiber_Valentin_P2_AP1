using Esthiber_Valentin_P2_AP1.DAL;
using Esthiber_Valentin_P2_AP1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Esthiber_Valentin_P2_AP1.Services
{
    public class DetailsEncuestasService(IDbContextFactory<Context> Dbfactory)
    {
        public async Task<bool> Insertar(DetailsEncuestasCiudades model)
        {
            return false;
        }

        public async Task<bool> Modificar(DetailsEncuestasCiudades model)
        {
            return false;
        }

        public async Task<bool> Guardar(DetailsEncuestasCiudades model)
        {
            return false;
        }
        public async Task<bool> Eliminar(int id)
        {
            return false;
        }


        public async Task<List<DetailsEncuestasCiudades>> Listar(Expression<Func<DetailsEncuestasCiudades, bool>> criterio)
        {
            return new();
        }
    }
}
