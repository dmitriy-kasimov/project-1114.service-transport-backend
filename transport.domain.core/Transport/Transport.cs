using AltV.Net.Elements.Entities;
using transport.domain.core.Transport.dto;

namespace transport.domain.core.Transport;

public abstract class Transport(TransportParams transportParams)
{
    private readonly TransportParams _transportParams = transportParams;
}