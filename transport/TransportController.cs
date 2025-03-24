using AltV.Net;
using AltV.Net.Elements.Entities;
using transport.domain.core;
using transport.infrastructure.business;
using transport.services.interfaces;

namespace Transport;

public class TransportController : Resource
{
    private ITransportService _transportService;
    
    public override IEntityFactory<IVehicle> GetVehicleFactory()
    {
        return new TransportFactory();
    }
    
    public override void OnStart()
    {
        _transportService = new TransportService();
    }

    public override void OnStop()
    {
            
    }
}
