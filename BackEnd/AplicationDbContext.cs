using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options): base(options)
        {

        }
        public DbSet<TarjetaCredito> TarjetaCredito { get; set; }
        

    }
}
