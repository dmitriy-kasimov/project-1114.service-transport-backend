using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Configurations;

public class BatteryConfiguration : IEntityTypeConfiguration<BatteryEntity>
{
    public void Configure(EntityTypeBuilder<BatteryEntity> builder)
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Name);
        builder.Property(entity => entity.MaxCharge);
        
        // many 2 many for each wagon
        builder
            .HasMany(c => c.CompatibleTransports)
            .WithMany(c => c.CompatibleBatteries);
    }
}