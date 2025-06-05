using AltV.Net;
namespace Transport;

public class Transport : Resource
{
    private TransportController? _controller;
    public override void OnStart()
    {
        _controller = new TransportController();
    }

    public override void OnStop()
    {
            
    }
}