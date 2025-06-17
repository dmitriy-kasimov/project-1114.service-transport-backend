using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using transport.domain.interfaces;

namespace transport.infrastructure.data;

public class TransportRepository : ITransportRepository
{
    public IVehicle Create(VehicleModel model, Position position, Rotation rotation)
    {
        return Alt.CreateVehicle(model, position, rotation);
    }
}