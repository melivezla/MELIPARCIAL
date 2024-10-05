namespace MELIPARCIAL.Data
{
    using Microsoft.EntityFrameworkCore;
    using MELIPARCIAL.Models; 

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Remesa> Remesas { get; set; } 
        public DbSet<ConversionHistorial> ConversionHistoriales { get; set; } 
    }
}
