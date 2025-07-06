using AltV.Net;
using AltV.Net.Elements.Entities;

namespace Transport;

public class Main : Resource
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