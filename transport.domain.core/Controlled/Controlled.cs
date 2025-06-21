using AltV.Net.Elements.Entities;
using transport.domain.core.Controlled.dto;
using transport.domain.core.Transport.dto;

namespace transport.domain.core.Controlled;

public abstract class Controlled(ControlledParams controlledParams,TransportParams transportParams) : Transport.Transport(transportParams)
{
    private ControlledParams _controlledParams = controlledParams;
}