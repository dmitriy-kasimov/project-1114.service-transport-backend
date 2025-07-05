using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Configurations;

public class PetrolConfiguration: IEntityTypeConfiguration<PetrolEntity>
{
    public void Configure(EntityTypeBuilder<PetrolEntity> builder)
    {
        builder.HasKey(entity => entity.Name);
        
        builder.Property(entity => entity.Capacity);
        
        // many 2 many for each wagon
        builder
            .HasMany(c => c.CompatibleTransports)
            .WithMany(c => c.CompatiblePetrol);
    }
}