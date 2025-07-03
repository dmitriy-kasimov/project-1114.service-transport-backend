using transport.domain.core;
using transport.domain.core.Overland;
using transport.domain.core.Overland.modules.Axis;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class AxisMapper
{
    public static Axis<AxisVariant, domain.core.Wagon.Models> ToModel(AxisEntity axisEntity)
    {
        var axisMetaData = new ModuleMetaData<domain.core.Wagon.Models>(axisEntity.Model, axisEntity.Name, axisEntity.CompatibleTransports);
        var axisSpecification = new AxisSpecification<AxisVariant>(axisEntity.Axis);
        return new Axis<AxisVariant, domain.core.Wagon.Models>(axisMetaData, axisSpecification, []);
    }

    public static AxisEntity ToEntity(Axis<AxisVariant, domain.core.Wagon.Models> axis)
    {
        return new AxisEntity()
        {
            Model = axis.MetaData.Model,
            Name = axis.MetaData.Name,
            CompatibleTransports = axis.MetaData.CompatiblyTransports,
            Axis = axis.Specification.Axis
        };
    }
}