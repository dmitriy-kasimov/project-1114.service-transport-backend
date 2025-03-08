using AltV.Net;
using AltV.Net.Elements.Entities;
using transport.domain.core;

namespace Transport;

public class Transport : Resource
{
    public override IEntityFactory<IVehicle> GetVehicleFactory()
    {
        return new TransportFactory();
    }
    public override void OnStart()
    {
            
    }

    public override void OnStop()
    {
            
    }
}
