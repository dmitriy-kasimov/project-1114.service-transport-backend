using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using transport.domain.core.Truck;
using transport.infrastructure.business;

namespace Transport;

public class TransportController : IScript
{
    private TruckService? _truckService;

    public TransportController()
    {
        _truckService = new TruckService();
    }

    [ClientEvent("c:s:CreateTruck")]
    public void CreateTruckHandler(Player player, string truckId)
    {
        var truckIdInt = Int32.Parse(truckId);
        var position = player.Position;
        var rotation = player.Rotation;
        var truck = _truckService?.Create((TruckModels)truckIdInt, position, rotation);
        player.SetIntoVehicle(truck?.Vehicle, 0);
    }
    
    public void CreateTruck(Player player, string truckId)
    {
        var truckIdInt = Int32.Parse(truckId);
        var position = player.Position;
        var rotation = player.Rotation;
        var truck = _truckService?.Create((TruckModels)truckIdInt, position, rotation);
        player.SetIntoVehicle(truck?.Vehicle, 0);
    }
    
    [ClientEvent("c:s:toggleEngineState")]
    public void ToggleEngineHandler(Player player)
    {
        Console.WriteLine("Trying to toggle...");
        if (player.IsInVehicle)
        {
            Console.WriteLine("Player is defined");
            var vehicle = player.Vehicle;
            vehicle.EngineOn = !vehicle.EngineOn;
            //_truckService?.ToggleEngine(vehicle);
            //var passengers = vehicle.Passengers;
            // foreach (var passenger in passengers)
            // {
            //     if (passenger.Player.Equals(player) && passenger.Seat == 0)
            //     {
            //         _truckService?.ToggleEngine(vehicle);
            //     }
            // }
        }
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