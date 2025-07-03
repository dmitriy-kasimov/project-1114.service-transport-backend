using transport.domain.core;
using transport.domain.core.Mechanical.modules.Battery;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class BatteryMapper
{
    public static Battery<domain.core.Wagon.Models> ToDomain(BatteryEntity battery)
    {
        var petrolMetaData = new ModuleMetaData<domain.core.Wagon.Models>(battery.Model, battery.Name, battery.CompatibleTransports);
        var petrolSpecification = new BatterySpecification(battery.MaxCharge);
        return  new Battery<domain.core.Wagon.Models>(petrolMetaData, petrolSpecification);
    }

    public static BatteryEntity ToModel(Battery<domain.core.Wagon.Models> battery)
    {
        return new BatteryEntity()
        {
            Model = battery.MetaData.Model,
            Name = battery.MetaData.Name,
            CompatibleTransports = battery.MetaData.CompatiblyTransports,
            MaxCharge = battery.Specification.MaxCharge
        };
    }
}