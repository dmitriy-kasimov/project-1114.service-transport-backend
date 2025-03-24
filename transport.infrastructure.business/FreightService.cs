using AltV.Net.Data;
using transport.domain.core.Freight;
using transport.domain.core.Freight.Axis;
using transport.domain.core.IGround.IChassis;
using transport.domain.core.IMechanical.IPlatform;
using transport.domain.interfaces;
using transport.infrastructure.data;
using transport.services.interfaces;

namespace transport.infrastructure.business;

public class FreightService : IFrightService
{
    private readonly IFreightRepository _freightRepository;
    public FreightService()
    {
        _freightRepository = new FreightRepository();
    }

    public void Create(FreightModels freightModel, Position position, Rotation rotation)
    {
        _freightRepository.Create(freightModel, position, rotation);
    }
}