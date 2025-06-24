using AltV.Net.Elements.Entities;

namespace transport.domain.core.Transport.dto;

public class TransportParams(IVehicle vehicle, Player? owner = null)
{
    public Player? Owner = owner;
    public IVehicle Vehicle = vehicle ;
}