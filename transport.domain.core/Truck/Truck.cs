using transport.domain.core.Transport.dto;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Overland;
using transport.domain.core.Overland.dto;
using transport.domain.core.Truck.dto;

namespace transport.domain.core.Truck;

public abstract class Truck<T, TA, TB>(TruckParams truckParams, OverlandParams<TA, TB> overlandParams, MechanicalParams<T, TB> mechanicalParams,  ControlledParams controlledParams, TransportParams transportParams) : Overland<T, TA, TB>(overlandParams ,mechanicalParams ,controlledParams, transportParams)
{
     public readonly TruckParams TruckParams = truckParams;
}