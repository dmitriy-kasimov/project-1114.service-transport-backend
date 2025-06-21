using AltV.Net.Elements.Entities;

namespace transport.domain.core;

public abstract class Controlled(IVehicle vehicle, float mileage = 0.0f, Player? owner = null) : Transport(vehicle, owner)
{
    private float _mileage = mileage;
}