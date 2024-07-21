using Microsoft.EntityFrameworkCore;

namespace CalculatorAPI.Entity
{
    public class CalculatorDbContext : DbContext
    {
        private string _connectionString = "Server=Plasto;Database=CalculatorUDB;Trusted_Connection=True;";
        
        public DbSet<InsulationCeiling> InsulationCeiling { get; set; }
        public DbSet<InsulationFoundation> InsulationFoundation { get; set; }
        public DbSet<InsulationWall> InsulationWalls { get; set; }

        public DbSet<FinishingCeiling> FinishingCeilings { get; set; }        
        public DbSet<FinishingInteriorWall> FinishingInteriorWalls { get; set; }
        public DbSet<FinishingFoundation> FinishingFoundations { get; set; }
        public DbSet<FinishingRoof> FinishingRoofs { get; set; }
        public DbSet<FinishingExteriorWall> FinishingExteriorWalls { get; set; }

        public DbSet<StructureCeiling> StructureCeiling { get; set; }
        public DbSet<StructureFoundation> StructureFoundation { get; set; }
        public DbSet<StructureRoof> StructureRoof { get; set; }
        public DbSet<StructureWall> StructureWalls { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Envelope> Envelopes { get; set; }
        public DbSet<Material> Materials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.UserName).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();
            //modelBuilder.Entity<Envelope>().Property(e => e.User).IsRequired();
            modelBuilder.Entity<Envelope>().Property(e => e.ValuU).HasPrecision(10, 4);
            modelBuilder.Entity<Material>().Property(m => m.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<InsulationCeiling>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<InsulationFoundation>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<InsulationWall>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<FinishingCeiling>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<FinishingInteriorWall>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<FinishingFoundation>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<FinishingRoof>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<FinishingExteriorWall>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<StructureCeiling>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<StructureFoundation>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<StructureRoof>().Property(x => x.Lambda).HasPrecision(10, 4);
            modelBuilder.Entity<StructureWall>().Property(x => x.Lambda).HasPrecision(10, 4);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
