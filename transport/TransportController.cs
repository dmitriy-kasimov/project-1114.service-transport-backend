using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using transport.domain.core.Truck;
using transport.infrastructure.business;

namespace Transport;

public class TransportController : Resource, IScript
{
    private TruckService? _truckService;
    public override void OnStart()
    {
        _truckService = new TruckService();
    }

    public override void OnStop()
    {
            
    }

    [ClientEvent("c:s:CreateTruck")]
    public void CreateTruckHandler(Player player, TruckModels truckId)
    {
        var position = player.Position;
        var rotation = player.Rotation;
        _truckService?.Create(truckId, position, rotation);
    }
    
    [ClientEvent("c:s:toggleEngine")]
    public void ToggleEngineHandler(Player player, IVehicle vehicle)
    {
        _truckService?.ToggleEngine(vehicle);
    }
}
