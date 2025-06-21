using transport.domain.core.Mechanical.components;
using transport.domain.core.Mechanical.components.Petrol;

namespace transport.domain.core.Mechanical.dto;

public abstract class MechanicalParams(FuelEngine fuelEngine, Petrol petrol, Battery battery)
{
    private FuelEngine _fuelEngine = fuelEngine;
    private Petrol _petrol = petrol;
    private Battery _battery = battery;
}