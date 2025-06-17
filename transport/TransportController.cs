using AltV.Net;
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