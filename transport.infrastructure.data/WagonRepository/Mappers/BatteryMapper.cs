using transport.domain.core;
using transport.domain.core.Mechanical.modules.Battery;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class BatteryMapper
{
    public static Battery<domain.core.Wagon.Models> ToDomain(BatteryEntity batteryEntity)
    {
        var compatibleWagonModels = batteryEntity.CompatibleTransports.ConvertAll(wagon => wagon.Model);
        var petrolMetaData = new ModuleMetaData<domain.core.Wagon.Models>(batteryEntity.Name, compatibleWagonModels);
        
        var petrolSpecification = new BatterySpecification(batteryEntity.MaxCharge);
        
        return  new Battery<domain.core.Wagon.Models>(petrolMetaData, petrolSpecification);
    }

    public static BatteryEntity ToModel(Battery<domain.core.Wagon.Models> battery, List<WagonEntity>? wagonEntities = null)
    {
        return new BatteryEntity
        {
            Name = battery.MetaData.Name,
            CompatibleTransports = wagonEntities ?? [],
            MaxCharge = battery.Specification.MaxCharge
        };
    }
}