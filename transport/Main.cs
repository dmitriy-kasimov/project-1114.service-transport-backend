using AltV.Net;
using AltV.Net.Elements.Entities;
using transport.domain.core;

namespace Transport;

public class Main : Resource
{
    public override IEntityFactory<Vehicle> GetVehicleFactory()
    {
        return new TransportFactory();
    }
    
    private TransportController? _controller;
    public override void OnStart()
    {
        _controller = new TransportController();
    }

    public override void OnStop()
    {
            
    }
}