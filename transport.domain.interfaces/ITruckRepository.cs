using AltV.Net.Data;
using transport.domain.core.Truck;

namespace transport.domain.interfaces;

public interface ITruckRepository
{
    public Truck Create(TrucksIds truckId, Position position, Rotation rotation);
}