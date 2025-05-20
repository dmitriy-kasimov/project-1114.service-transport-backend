using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using transport.domain.core.Truck;
using transport.infrastructure.data;
using transport.services.interfaces;
using AltV.Net.Enums;

namespace transport.infrastructure.business;

public class TruckService : ITruckService
{
    private TruckRepository TruckRepository { get; }
    private Dictionary<IVehicle, Truck>? _trucks { get; } 
    
    public TruckService()
    {
        TruckRepository = new TruckRepository();
    }

    ~TruckService()
    {
        foreach (var truck in _trucks)
        {
            truck.Value.Vehicle.Destroy();
        }
        _trucks.Clear();
    }

    public void Create(TruckModels truckId, Position position, Rotation rotation)
    {
        var truck = TruckRepository.Create(truckId, position, rotation);
        var id = truck.Vehicle;
        _trucks.Add(id, truck);
    }

    public void ToggleEngine(IVehicle vehicle)
    {
        _trucks[vehicle].Vehicle.EngineOn = !_trucks[vehicle].Vehicle.EngineOn;
    }
    
    public void SetLights(IVehicle vehicle, byte mode)
    {
        /* https://docs.fivem.net/natives/?_0x34E710FF01247C5A */
        _trucks[vehicle].Vehicle.LightState = mode;
    }
    
    public void SetDoor(IVehicle vehicle, VehicleDoor door, VehicleDoorState doorState)
    {
        _trucks[vehicle].Vehicle.SetDoorStateExt(door, doorState);
    }
}