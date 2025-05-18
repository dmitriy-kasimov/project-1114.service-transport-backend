using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using transport.domain.core.Truck;

namespace transport.services.interfaces;

public interface ITruckService
{
    public void Create(TruckModels truckId, Position position, Rotation rotation);
    public void ToggleEngine(IVehicle vehicle);
    public void ToggleLights(IVehicle vehicle);
    public void ToggleDoors(IVehicle vehicle);
}