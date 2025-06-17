using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using transport.domain.core.Truck;
using transport.infrastructure.business;

namespace Transport;

public class TransportController : IScript
{
    private TransportService? _transportService;

    public TransportController()
    {
        _transportService = new TransportService();
    }
    
}