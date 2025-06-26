using transport.domain.core.Transport.dto;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Overland.dto;

namespace transport.domain.core.Overland;

public abstract class Overland<T, TA>(OverlandParams<TA> overlandParams, MechanicalParams<T> mechanicalParams,  ControlledParams controlledParams, TransportParams transportParams) : Mechanical.Mechanical<T>(mechanicalParams ,controlledParams, transportParams)
{
    public OverlandParams<TA> OverlandParams => overlandParams;
}