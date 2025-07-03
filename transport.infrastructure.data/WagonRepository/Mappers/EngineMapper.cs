using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Engine;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class EngineMapper
{
    public static Engine<FuelType, domain.core.Wagon.Models> ToDomain(EngineEntity engineEntity)
    {
        var engineMetaData = new ModuleMetaData<domain.core.Wagon.Models>(engineEntity.Model, engineEntity.Name,
            engineEntity.CompatibleTransports);
        var engineSpecification = new EngineSpecification<FuelType>(engineEntity.Bsfc, engineEntity.AcceptedTypesFuel);
        return new Engine<FuelType, domain.core.Wagon.Models>(engineMetaData, engineSpecification);
    }

    public static EngineEntity ToModel(Engine<FuelType, domain.core.Wagon.Models> engine)
    {
        return new EngineEntity()
        {
            Model = engine.MetaData.Model,
            Name = engine.MetaData.Name,
            CompatibleTransports = engine.MetaData.CompatiblyTransports,
            AcceptedTypesFuel = engine.Specification.AcceptedTypesFuel,
            Bsfc = engine.Specification.Bsfc,
        };
    }
}