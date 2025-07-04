using transport.domain.core;
using transport.domain.core.Mechanical.modules.Battery;
using transport.infrastructure.data.WagonRepository.Models;

namespace transport.infrastructure.data.WagonRepository.Mappers;

public static class BatteryMapper
{
    public static Battery<WagonEntity> ToDomain(BatteryEntity battery)
    {
        var petrolMetaData = new ModuleMetaData<WagonEntity>(battery.Id, battery.Name, battery.CompatibleTransports);
        var petrolSpecification = new BatterySpecification(battery.MaxCharge);
        return  new Battery<WagonEntity>(petrolMetaData, petrolSpecification);
    }

    public static BatteryEntity ToModel(Battery<WagonEntity> battery)
    {
        return new BatteryEntity()
        {
            Name = battery.MetaData.Name,
            CompatibleTransports = battery.MetaData.CompatiblyTransports,
            MaxCharge = battery.Specification.MaxCharge
        };
    }
}