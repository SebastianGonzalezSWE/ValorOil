using Microsoft.EntityFrameworkCore;

namespace Valor.Models
{
    public class ValorContext : DbContext
    {
        public ValorContext (DbContextOptions<ValorContext> options)
            : base (options)
            {
            }
        
        public DbSet<Operator> Operators {get; set;} = default!;
        public DbSet<Well> Wells {get; set;} = default!;

        public DbSet<Report> Reports {get; set;} = default!;

    }
}