using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonAxisRepository.Models;
using transport.infrastructure.data.WagonEngineRepository.Models;

namespace transport.infrastructure.data.WagonAxisRepository.Configurations;

public class AxisConfiguration<T> : IEntityTypeConfiguration<AxisEntity<T>>
{
    public void Configure(EntityTypeBuilder<AxisEntity<T>> builder)
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Model);
        builder.Property(entity => entity.Name);
        builder.Property(entity => entity.Axis);
    }
}