using transport.domain.core.Wagon;
using transport.domain.interfaces;

namespace transport.infrastructure.data.WagonRepository;

public class WagonRepository : IWagonRepository<FuelType, AxisVariant>
{
    public Wagon<FuelType, AxisVariant> Create(Models model)
    {
        /* по модели определить модули */
        
        //Alt.CreateVehicle((uint)model, new Position(), new Rotation());
        
        return new Wagon<FuelType, AxisVariant>();
    }
}