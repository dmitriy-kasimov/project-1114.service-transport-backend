using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;

namespace transport.services.interfaces;

public interface ITransportService
{
    public void Create(VehicleModel model, Position position, Rotation rotation);
}