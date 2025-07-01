using Microsoft.EntityFrameworkCore;
using transport.domain.core.Mechanical;
using transport.domain.core.Overland;
using transport.domain.core.Wagon;
using transport.infrastructure.data.WagonRepository.Configurations;

namespace transport.infrastructure.data.WagonRepository;

public class WagonDbContext : DbContext
{
    public DbSet<Wagon<FuelType, AxisVariant>> Wagons { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("SERVER=localhost;DATABASE=service-transport;UID=root;Password=;Pooling=true;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WagonConfiguration<FuelType>());
    }
}