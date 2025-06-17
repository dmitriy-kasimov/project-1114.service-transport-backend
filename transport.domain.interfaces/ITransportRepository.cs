using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using transport.domain.core.Truck;

namespace transport.domain.interfaces;

public interface ITransportRepository
{
    public IVehicle Create(VehicleModel model, Position position, Rotation rotation);
}