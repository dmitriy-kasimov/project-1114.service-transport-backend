using AltV.Net.Data;
using transport.domain.core.Truck;
using transport.domain.interfaces;

namespace transport.infrastructure.data;

public class TruckRepository : ITruckRepository
{
    public Truck Create(TruckModels truckId, Position position, Rotation rotation)
    {
        return new Truck(truckId, position, rotation);
    }
}