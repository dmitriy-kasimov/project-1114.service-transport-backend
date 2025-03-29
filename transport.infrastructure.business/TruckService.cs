using AltV.Net.Data;
using transport.domain.core.Truck;
using transport.infrastructure.data;
using transport.services.interfaces;

namespace transport.infrastructure.business;

public class TruckService : ITruckService
{
    private TruckRepository TruckRepository { get; }
    
    public TruckService()
    {
        TruckRepository = new TruckRepository();
    }

    public void Create(TruckModels truckId, Position position, Rotation rotation)
    {
        var Z = TruckRepository.Create(truckId, position, rotation);
    }
}