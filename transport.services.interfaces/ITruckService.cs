using AltV.Net.Data;
using transport.domain.core.Truck;

namespace transport.services.interfaces;

public interface ITruckService
{
    public void Create(TruckModels truckId, Position position, Rotation rotation);
}