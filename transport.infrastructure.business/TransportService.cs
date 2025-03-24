using AltV.Net.Data;
using AltV.Net.Enums;
using transport.infrastructure.data;
using transport.services.interfaces;


namespace transport.infrastructure.business;

public class TransportService : ITransportService
{
    private readonly TransportRepository _transportRepository;
    public TransportService()
    {
        _transportRepository = new TransportRepository();
    }

    public void Create(VehicleModel vehicleModel, Position position, Rotation rotation)
    {
        _transportRepository.Create(vehicleModel, position, rotation);
    }
}