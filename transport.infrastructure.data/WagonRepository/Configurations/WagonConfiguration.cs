using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Configurations;

public class WagonConfiguration : IEntityTypeConfiguration<WagonEntity>
{
    public void Configure(EntityTypeBuilder<WagonEntity> builder)
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Model);
        
        // builder.Property(entity => entity.CompatibleEngines);
        // builder.Property(entity => entity.CompatibleAxis);
        // builder.Property(entity => entity.CompatibleBatteries);
        // builder.Property(entity => entity.CompatiblePetrol);
        
        // many 2 many for each module
        builder
            .HasMany(c => c.CompatibleWagonAxis)
            .WithMany(c => c.CompatibleWagons);
        
        builder
            .HasMany(c => c.CompatibleWagonEngines)
            .WithMany(c => c.CompatibleWagons);
        
        builder
            .HasMany(c => c.CompatibleWagonPetrol)
            .WithMany(c => c.CompatibleWagons);
        
        builder
            .HasMany(c => c.CompatibleWagonBatteries)
            .WithMany(c => c.CompatibleWagons);
    }
}