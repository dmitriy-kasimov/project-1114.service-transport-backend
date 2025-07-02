using transport.domain.core.Transport.dto;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Overland.dto;

namespace transport.domain.core.Overland;

public abstract class Overland<T, TA, TB>(OverlandParams<TA, TB> overlandParams, MechanicalParams<T, TB> mechanicalParams,  ControlledParams controlledParams, TransportParams transportParams) : Mechanical.Mechanical<T, TB>(mechanicalParams ,controlledParams, transportParams)
{
    public OverlandParams<TA, TB> OverlandParams => overlandParams;
}