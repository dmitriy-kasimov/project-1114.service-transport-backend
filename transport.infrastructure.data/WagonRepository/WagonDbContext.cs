using Microsoft.EntityFrameworkCore;
using transport.domain.core.Mechanical;
using transport.domain.core.Overland;
using transport.infrastructure.data.WagonRepository.Configurations;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository;

public class WagonDbContext : DbContext
{
    public DbSet<WagonEntity> Wagons { get; set; }
    public DbSet<AxisEntity> WagonAxis { get; set; }
    public DbSet<BatteryEntity> WagonBatteries { get; set; }
    public DbSet<EngineEntity> WagonEngines { get; set; }
    public DbSet<PetrolEntity> WagonPetrol { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("SERVER=localhost;DATABASE=service-transport;UID=root;Password=;Pooling=true;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WagonConfiguration<FuelType>());
        modelBuilder.ApplyConfiguration(new AxisConfiguration<AxisVariant>());
        modelBuilder.ApplyConfiguration(new BatteryConfiguration());
        modelBuilder.ApplyConfiguration(new EngineConfiguration());
        modelBuilder.ApplyConfiguration(new PetrolConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}