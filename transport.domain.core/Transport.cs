using AltV.Net;
using AltV.Net.Elements.Entities;

namespace transport.domain.core;

public class Transport : Vehicle
{
    public Transport(ICore core, IntPtr nativePointer, uint id) : base(core, nativePointer, id)
    {
        
    }
}

public class TransportFactory : IEntityFactory<IVehicle>
{
    public IVehicle Create(ICore core, IntPtr playerPointer, uint id)
    {
        return new Transport(core, playerPointer, id);
    }
}