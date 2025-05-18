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
    private Dictionary<IVehicle, Truck> _trucks { get; } 
    
    public TruckService()
    {
        TruckRepository = new TruckRepository();
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
    
    public void ToggleLights(IVehicle vehicle)
    {
        /* some logic with lights */
        /* https://docs.fivem.net/natives/?_0x34E710FF01247C5A */
    }
    
    public void ToggleDoors(IVehicle vehicle)
    {
        /* some logic with doors */
    }
}