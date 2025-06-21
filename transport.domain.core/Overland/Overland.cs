using AltV.Net.Elements.Entities;
using transport.domain.core.Mechanical.components;
using transport.domain.core.Overland.components;

namespace transport.domain.core.Overland;

public abstract class Overland(Axis axis, FuelEngine fuelEngine, Petrol petrol, Battery battery, IVehicle vehicle, float mileage = 0, Player? owner = null) : Mechanical.Mechanical(fuelEngine, petrol, battery, vehicle, mileage, owner)
{
    private Axis _axis = axis;
}