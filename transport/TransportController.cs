using AltV.Net;
using AltV.Net.Elements.Entities;
using transport.domain.core;
using transport.infrastructure.business;
using transport.services.interfaces;

namespace Transport;

public class TransportController : Resource
{
    private IFrightService _freightService;
    
    public override IEntityFactory<IVehicle> GetVehicleFactory()
    {
        return new TransportFactory();
    }
    
    public override void OnStart()
    {
        _freightService = new FreightService();
    }

    public override void OnStop()
    {
            
    }
}
