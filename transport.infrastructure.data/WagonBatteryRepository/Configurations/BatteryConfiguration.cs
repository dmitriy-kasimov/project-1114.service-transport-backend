using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using transport.infrastructure.data.WagonBatteryRepository.Models;
using transport.infrastructure.data.WagonEngineRepository.Models;

namespace transport.infrastructure.data.WagonBatteryRepository.Configurations;

public class BatteryConfiguration : IEntityTypeConfiguration<BatteryEntity>
{
    public void Configure(EntityTypeBuilder<BatteryEntity> builder)
    {
        builder.HasKey(entity => entity.Id);
        builder.Property(entity => entity.Model);
        builder.Property(entity => entity.Name);
        builder.Property(entity => entity.MaxCharge);
    }
}