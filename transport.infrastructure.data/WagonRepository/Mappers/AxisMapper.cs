using transport.domain.core;
using transport.domain.core.Overland;
using transport.domain.core.Overland.modules.Axis;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class AxisMapper
{
    public static Axis<AxisVariant, domain.core.Wagon.Models> ToDomain(AxisEntity axisEntity)
    {
        var compatibleWagonModels = axisEntity.CompatibleTransports.ConvertAll(wagon => wagon.Model);
        var metaData = new ModuleMetaData<domain.core.Wagon.Models>(axisEntity.Name, compatibleWagonModels);
        
        var specification = new AxisSpecification<AxisVariant>(axisEntity.Axis);
        
        return new Axis<AxisVariant, domain.core.Wagon.Models>(metaData, specification, []);
    }

    public static AxisEntity ToModel(Axis<AxisVariant, domain.core.Wagon.Models> axis, List<WagonEntity>? wagonEntities = null)
    {
        return new AxisEntity
        {
            Name = axis.MetaData.Name,
            CompatibleTransports = wagonEntities ?? [],
            Axis = axis.Specification.Axis
        };
    }
}