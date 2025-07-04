using transport.domain.core;
using transport.domain.core.Overland;
using transport.domain.core.Overland.modules.Axis;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class AxisMapper
{
    public static Axis<AxisVariant, WagonEntity> ToDomain(AxisEntity axisEntity)
    {
        var axisMetaData = new ModuleMetaData<WagonEntity>(axisEntity.Id, axisEntity.Name, axisEntity.CompatibleTransports);
        var axisSpecification = new AxisSpecification<AxisVariant>(axisEntity.Axis);
        return new Axis<AxisVariant, WagonEntity>(axisMetaData, axisSpecification, []);
    }

    public static AxisEntity ToModel(Axis<AxisVariant, WagonEntity> axis)
    {
        return new AxisEntity()
        {
            Name = axis.MetaData.Name,
            CompatibleTransports = axis.MetaData.CompatiblyTransports,
            Axis = axis.Specification.Axis
        };
    }
}