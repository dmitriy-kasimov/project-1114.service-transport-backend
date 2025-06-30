using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonEngineRepository.Models;

namespace transport.infrastructure.data.WagonEngineRepository.Configurations;

public class EngineConfiguration<T> : IEntityTypeConfiguration<EngineEntity<T>>
{
    public void Configure(EntityTypeBuilder<EngineEntity<T>> builder)
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Model);
        builder.Property(entity => entity.Name);
        builder.Property(entity => entity.Bsfc);
        builder.Property(entity => entity.AcceptedTypesFuel);
    }
}