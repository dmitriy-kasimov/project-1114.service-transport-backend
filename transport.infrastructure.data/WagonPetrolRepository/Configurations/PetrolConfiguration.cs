using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonPetrolRepository.Models;

namespace transport.infrastructure.data.WagonPetrolRepository.Configurations;

public class PetrolConfiguration: IEntityTypeConfiguration<PetrolEntity>
{
    public void Configure(EntityTypeBuilder<PetrolEntity> builder)
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Model);
        builder.Property(entity => entity.Name);
        
        builder.Property(entity => entity.Capacity);
    }
}