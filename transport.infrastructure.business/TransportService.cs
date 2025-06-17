using AltV.Net;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Enums;
using transport.domain.core;
using transport.domain.core.Truck;
using transport.infrastructure.data;
using transport.services.interfaces;


namespace transport.infrastructure.business;

public class TransportService : ITransportService
{
    private TransportRepository _transportRepository { get; }
    
    public TransportService()
    {
        _transportRepository = new TransportRepository();
    }
    
    public void Create(VehicleModel model, Position position, Rotation rotation)
    {
        _transportRepository.Create(model, position, rotation);
    }
}