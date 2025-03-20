using AltV.Net.Data;
using AltV.Net.Enums;
using transport.domain.core;

namespace transport.services.interfaces;

public interface ITransportService
{
    public void Create(VehicleModel vehicleModel, Position position, Rotation rotation);
}