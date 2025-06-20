using AltV.Net.Elements.Entities;

namespace transport.domain.core.Transport.dto;

public abstract class TransportParams(IVehicle vehicle, Player? owner = null)
{
    private Player? _owner = owner;
    private IVehicle _vehicle = vehicle;
}