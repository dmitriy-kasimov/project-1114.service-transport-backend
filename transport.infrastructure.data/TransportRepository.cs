using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Enums;
using transport.domain.interfaces;

namespace transport.infrastructure.data;

public class TransportRepository : ITransportRepository
{
    public void Create(VehicleModel vehicleModel, Position position, Rotation rotation)
    {
        Alt.CreateVehicle(vehicleModel, position, rotation);
    }
}