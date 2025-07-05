using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Configurations;

public class AxisConfiguration : IEntityTypeConfiguration<AxisEntity>
{
    public void Configure(EntityTypeBuilder<AxisEntity> builder)
    {
        builder.HasKey(entity => entity.Name);
        builder.Property(entity => entity.Axis);
        
        // many 2 many for each wagon
        builder
            .HasMany(c => c.CompatibleTransports)
            .WithMany(c => c.CompatibleAxis);
    }
}