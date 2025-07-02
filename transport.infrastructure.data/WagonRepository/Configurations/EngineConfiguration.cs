using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Configurations;

public class EngineConfiguration : IEntityTypeConfiguration<EngineEntity>
{
    public void Configure(EntityTypeBuilder<EngineEntity> builder)
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Model);
        builder.Property(entity => entity.Name);
        builder.Property(entity => entity.Bsfc);
        builder.Property(entity => entity.AcceptedTypesFuel);

        builder.Property(entity => entity.CompatibleTransports);
        
        // builder
        //     .HasMany(c => c.CompatibleModels)
        //     .WithMany(c => c.CompatibleEngines);
    }
}