using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
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
    
    [ClientEvent("c:s:setLights")]
    public void SetLightsHandler(Player player, IVehicle vehicle, byte mode)
    {
        _truckService?.SetLights(vehicle, mode);
    }
    
    [ClientEvent("c:s:setDoor")]
    public void SetDoorHandler(Player player, IVehicle vehicle, VehicleDoor door, VehicleDoorState doorState)
    {
        _truckService?.SetDoor(vehicle, door, doorState);
    }
}
