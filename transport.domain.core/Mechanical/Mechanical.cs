using AltV.Net.Elements.Entities;
using transport.domain.core.Mechanical.components;

namespace transport.domain.core.Mechanical;

public abstract class Mechanical(FuelEngine fuelEngine, Petrol petrol, Battery battery, IVehicle vehicle, float mileage = 0, Player? owner = null) : Controlled(vehicle, mileage, owner)
{
   private FuelEngine _fuelEngine = fuelEngine;
   private Petrol _petrol = petrol;
   private Battery _battery = battery;
}