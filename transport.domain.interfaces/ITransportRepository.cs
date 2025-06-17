using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace transport.domain.interfaces;

public interface ITransportRepository
{
    public IVehicle Create(VehicleModel model, Position position, Rotation rotation);
}