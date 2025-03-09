using Microsoft.EntityFrameworkCore;

namespace Esthiber_Valentin_P2_AP1.DAL
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {

    }
}
