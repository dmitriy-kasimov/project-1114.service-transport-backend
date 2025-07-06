using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Engine;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class EngineMapper
{
    public static Engine<FuelType, domain.core.Wagon.Models> ToDomain(EngineEntity engineEntity)
    {
        var compatibleWagonModels = engineEntity.CompatibleTransports.ConvertAll(wagon => wagon.Model);
        var engineMetaData = new ModuleMetaData<domain.core.Wagon.Models>(engineEntity.Name, compatibleWagonModels);
        
        var engineSpecification = new EngineSpecification<FuelType>(engineEntity.Bsfc, engineEntity.AcceptedTypesFuel);
        
        return new Engine<FuelType, domain.core.Wagon.Models>(engineMetaData, engineSpecification);
    }

    public static EngineEntity ToModel(Engine<FuelType, domain.core.Wagon.Models> engine)
    {
        return new EngineEntity
        {
            Name = engine.MetaData.Name,
            CompatibleTransports = [],
            AcceptedTypesFuel = engine.Specification.AcceptedTypesFuel,
            Bsfc = engine.Specification.Bsfc,
        };
    }
}