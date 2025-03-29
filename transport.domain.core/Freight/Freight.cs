using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using transport.domain.core.Freight.Modules;

namespace transport.domain.core.Freight;

public class Freight
{
    public FreightModules Modules { get; }
    public IVehicle Vehicle { get; }

    public Freight(FreightIds freightId, Position position, Rotation rotation)
    {
        Modules = FrightModulesDictionary.GetById[freightId];
        Vehicle = Alt.CreateVehicle(FreightsDictionary.GetAltModelByFrightId[freightId], position, rotation);
    }

    ~Freight()
    {
        Vehicle.Destroy();
    }
}