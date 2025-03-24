using AltV.Net.Data;
using AltV.Net.Enums;

namespace transport.domain.interfaces;

public interface ITransportRepository
{
    public void Create(VehicleModel vehicleModel, Position position, Rotation rotation);
}