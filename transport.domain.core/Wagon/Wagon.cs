using transport.domain.core.Transport.dto;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Overland.dto;
using transport.domain.core.Truck;
using transport.domain.core.Truck.dto;
using transport.domain.core.Wagon.dto;

namespace transport.domain.core.Wagon;

public class Wagon<T, TA>(WagonParams wagonParams, TruckParams truckParams, OverlandParams<TA, Models> overlandParams, MechanicalParams<T, Models> mechanicalParams,  ControlledParams controlledParams, TransportParams transportParams) : Truck<T, TA, Models>(truckParams, overlandParams, mechanicalParams ,controlledParams, transportParams)
{
     public WagonParams Params = wagonParams;
}