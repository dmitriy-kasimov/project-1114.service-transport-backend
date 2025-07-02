using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Transport.dto;

namespace transport.domain.core.Mechanical;

public abstract class Mechanical<T, TA>(MechanicalParams<T, TA> mechanicalParams,  ControlledParams controlledParams, TransportParams transportParams) : Controlled.Controlled(controlledParams, transportParams)
{
   public MechanicalParams<T, TA> MechanicalParams => mechanicalParams;
}