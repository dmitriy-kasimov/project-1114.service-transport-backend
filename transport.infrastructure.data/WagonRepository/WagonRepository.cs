using transport.domain.core.Wagon;
using transport.domain.interfaces;

namespace transport.infrastructure.data.WagonRepository;

public class WagonRepository : IWagonRepository<FuelType, AxisVariant>
{
    public Wagon<FuelType, AxisVariant> Create()
    {
        /* по модели определить модули */

        return new Wagon<FuelType, AxisVariant>();
    }
}