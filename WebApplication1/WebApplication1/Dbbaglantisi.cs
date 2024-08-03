using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class Dbbaglantisi : DbContext
    {
        public Dbbaglantisi(DbContextOptions<Dbbaglantisi> options) : base(options)
        {
        }
    }
}
