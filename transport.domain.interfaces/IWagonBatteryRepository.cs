using transport.domain.core;
using transport.domain.core.Mechanical.modules.Battery;

namespace transport.domain.interfaces;

public interface IWagonBatteryRepository
{
    public Task<Battery?> GetByModelAsync(string model);
    public Task AddAsync(EntityMetaData entityMetaData, BatterySpecification batterySpecification);
}