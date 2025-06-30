using Microsoft.EntityFrameworkCore;
using transport.domain.core.Mechanical;
using transport.infrastructure.data.WagonBatteryRepository.Configurations;
using transport.infrastructure.data.WagonBatteryRepository.Models;
using transport.infrastructure.data.WagonEngineRepository.Configurations;
using transport.infrastructure.data.WagonEngineRepository.Models;

namespace transport.infrastructure.data.WagonBatteryRepository;

public class WagonBatteryDbContext : DbContext
{
    public DbSet<BatteryEntity> WagonBatteries { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("SERVER=localhost;DATABASE=service-transport;UID=root;Password=;Pooling=true;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BatteryConfiguration());
    }
}