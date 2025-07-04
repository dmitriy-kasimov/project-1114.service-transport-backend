using transport.domain.core.Transport.dto;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Overland.dto;
using transport.domain.core.Truck;
using transport.domain.core.Truck.dto;
using transport.domain.core.Wagon.dto;

namespace transport.domain.core.Wagon;

public class Wagon<T, TA, TE>(WagonParams wagonParams, TruckParams truckParams, OverlandParams<TA, TE> overlandParams, MechanicalParams<T, TE> mechanicalParams,  ControlledParams controlledParams, TransportParams transportParams) : Truck<T, TA, TE>(truckParams, overlandParams, mechanicalParams ,controlledParams, transportParams)
{
     public WagonParams Params = wagonParams;
}