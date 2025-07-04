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
        
        // many 2 many for each module
        builder
            .HasMany(c => c.CompatibleAxis)
            .WithMany(c => c.CompatibleTransports);
        
        builder
            .HasMany(c => c.CompatibleEngines)
            .WithMany(c => c.CompatibleTransports);
        
        builder
            .HasMany(c => c.CompatiblePetrol)
            .WithMany(c => c.CompatibleTransports);
        
        builder
            .HasMany(c => c.CompatibleBatteries)
            .WithMany(c => c.CompatibleTransports);
    }
}