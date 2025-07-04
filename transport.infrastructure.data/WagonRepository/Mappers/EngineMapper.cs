using transport.domain.core;
using transport.domain.core.Mechanical;
using transport.domain.core.Mechanical.modules.Engine;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class EngineMapper
{
    public static Engine<FuelType, WagonEntity> ToDomain(EngineEntity engineEntity)
    {
        var engineMetaData = new ModuleMetaData<WagonEntity>(engineEntity.Id, engineEntity.Name,
            engineEntity.CompatibleTransports);
        var engineSpecification = new EngineSpecification<FuelType>(engineEntity.Bsfc, engineEntity.AcceptedTypesFuel);
        return new Engine<FuelType, WagonEntity>(engineMetaData, engineSpecification);
    }

    public static EngineEntity ToModel(Engine<FuelType, WagonEntity> engine)
    {
        return new EngineEntity()
        {
            Name = engine.MetaData.Name,
            CompatibleTransports = engine.MetaData.CompatiblyTransports,
            AcceptedTypesFuel = engine.Specification.AcceptedTypesFuel,
            Bsfc = engine.Specification.Bsfc,
        };
    }
}