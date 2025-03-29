using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using transport.domain.core.Truck.Modules;

namespace transport.domain.core.Truck;

public class Truck
{
    public TruckModules Modules { get; }
    public IVehicle Vehicle { get; }

    public Truck(TruckModels truckModel, Position position, Rotation rotation)
    {
        Modules = TruckModulesDictionary.GetByModel[truckModel];
        Vehicle = Alt.CreateVehicle(TrucksDictionary.GetAltModelByTruckModel[truckModel], position, rotation);
    }

    ~Truck()
    {
        Vehicle.Destroy();
    }
}