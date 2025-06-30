using Microsoft.EntityFrameworkCore;
using transport.domain.core.Mechanical;
using transport.infrastructure.data.WagonPetrolRepository.Configurations;
using transport.infrastructure.data.WagonPetrolRepository.Models;

namespace transport.infrastructure.data.WagonPetrolRepository;

public class WagonPetrolDbContext : DbContext
{
    public DbSet<PetrolEntity> WagonPetrol { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL("SERVER=localhost;DATABASE=service-transport;UID=root;Password=;Pooling=true;");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PetrolConfiguration());
    }
}