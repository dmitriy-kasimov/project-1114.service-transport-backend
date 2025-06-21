using transport.domain.core.Transport.dto;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Mechanical.dto;
using transport.domain.core.Overland.dto;

namespace transport.domain.core.Overland;

public abstract class Overland(OverlandParams overlandParams, MechanicalParams mechanicalParams,  ControlledParams controlledParams, TransportParams transportParams) : Mechanical.Mechanical(mechanicalParams ,controlledParams, transportParams)
{
    private OverlandParams _overlandParams = overlandParams;
}