using AltV.Net.Elements.Entities;

namespace transport.domain.core;

public abstract class Transport(IVehicle vehicle, Player? owner = null)
{
    private Player? _owner = owner;
    private IVehicle _vehicle = vehicle;
}