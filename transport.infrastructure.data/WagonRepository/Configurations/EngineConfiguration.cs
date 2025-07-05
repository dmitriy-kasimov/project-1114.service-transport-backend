using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Configurations;

public class EngineConfiguration : IEntityTypeConfiguration<EngineEntity>
{
    public void Configure(EntityTypeBuilder<EngineEntity> builder)
    {
        builder.HasKey(entity => entity.Name);
        builder.Property(entity => entity.Bsfc);
        builder.Property(entity => entity.AcceptedTypesFuel);
        
        // many 2 many for each wagon
        builder
            .HasMany(c => c.CompatibleTransports)
            .WithMany(c => c.CompatibleEngines);
    }
}