using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using transport.domain.core.Truck.Modules;

namespace transport.domain.core.Truck;

public class Truck
{
    public TruckModules Modules { get; }
    public IVehicle Vehicle { get; }

    public Truck(TrucksIds truckId, Position position, Rotation rotation)
    {
        Modules = TruckModulesDictionary.GetById[truckId];
        Vehicle = Alt.CreateVehicle(FreightsDictionary.GetAltModelByFrightId[truckId], position, rotation);
    }

    ~Truck()
    {
        Vehicle.Destroy();
    }
}