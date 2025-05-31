using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using transport.domain.core.Truck;
using AltV.Net.Enums;

namespace transport.services.interfaces;

public interface ITruckService
{
    public Truck Create(TruckModels truckId, Position position, Rotation rotation);
    public void ToggleEngine(IVehicle vehicle);
    public void SetLights(IVehicle vehicle, byte mode);
    public void SetDoor(IVehicle vehicle, VehicleDoor door, VehicleDoorState doorState);
}