using transport.domain.core.Mechanical.components;
using transport.domain.core.Mechanical.components.Battery;
using transport.domain.core.Mechanical.components.Engine;
using transport.domain.core.Mechanical.components.Petrol;

namespace transport.domain.core.Mechanical.dto;

public abstract class MechanicalParams(Engine engine, Petrol petrol, Battery battery)
{
    private Engine _engine = engine;
    private Petrol _petrol = petrol;
    private Battery _battery = battery;
}