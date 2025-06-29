using Microsoft.EntityFrameworkCore;
using transport.domain.core.Mechanical;
using transport.infrastructure.data.Configurations;
using transport.infrastructure.data.Models;

namespace transport.infrastructure.data.WagonRepository;

//public class WagonDbContext<T>(DbContextOptions<WagonDbContext<T>> options) : DbContext(options)
public class WagonDbContext : DbContext
{
    public DbSet<EngineEntity<FuelType>> Engines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("SERVER=localhost;DATABASE=service-transport;UID=root;Password=;Pooling=true;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EngineConfiguration<FuelType>());
    }
}