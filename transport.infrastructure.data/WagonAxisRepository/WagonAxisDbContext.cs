using Microsoft.EntityFrameworkCore;
using transport.domain.core.Mechanical;
using transport.domain.core.Overland;
using transport.infrastructure.data.WagonAxisRepository.Configurations;
using transport.infrastructure.data.WagonAxisRepository.Models;

namespace transport.infrastructure.data.WagonAxisRepository;

public class WagonAxisDbContext : DbContext
{
    public DbSet<AxisEntity<AxisVariant>> WagonAxis { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("SERVER=localhost;DATABASE=service-transport;UID=root;Password=;Pooling=true;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AxisConfiguration<AxisVariant>());
    }
}