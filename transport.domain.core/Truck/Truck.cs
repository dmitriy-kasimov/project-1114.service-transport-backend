using AltV.Net.Elements.Entities;
using transport.domain.core.Mechanical.components;
using transport.domain.core.Overland.components;
using transport.domain.core.Truck.dto;

namespace transport.domain.core.Truck;

public abstract class Truck(TruckParams truckParams, Axis axis, FuelEngine fuelEngine, Petrol petrol, Battery battery, IVehicle vehicle, float mileage = 0, Player? owner = null) : Overland.Overland(axis, fuelEngine, petrol, battery, vehicle, mileage, owner)
{
     private readonly TruckParams _truckParams = truckParams;
}