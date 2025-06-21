using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Overland.dto;
using transport.domain.core.Transport.dto;
using transport.domain.core.Truck.dto;

namespace transport.domain.core.Truck;

public abstract class Truck(TruckParams truckParams, OverlandParams overlandParams, MechanicalParams mechanicalParams,  ControlledParams controlledParams, TransportParams transportParams) : Overland.Overland(overlandParams ,mechanicalParams ,controlledParams, transportParams)
{
     private readonly TruckParams _truckParams = truckParams;
}