using transport.domain.core.Mechanical;
using transport.domain.core.Overland;
using transport.domain.core.Wagon;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class WagonMapper
{
    public static WagonEntity ToModel(domain.core.Wagon.Models model, 
        List<AxisEntity>? axisEntities = null, 
        List<BatteryEntity>? batteryEntities = null, 
        List<EngineEntity>? engines = null, 
        List<PetrolEntity>? petrolEntities = null)
    {
        return new WagonEntity()
        {
            Model = model,
            CompatibleAxis = axisEntities ?? [],
            CompatibleBatteries = batteryEntities ?? [],
            CompatibleEngines = engines ?? [],
            CompatiblePetrol = petrolEntities ?? []
        };
    }
}