using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;

namespace transport.domain.core.Mechanical.dto;

public abstract class MechanicalParams(Engine engine, Petrol petrol, Battery battery)
{
    private Engine _engine = engine;
    private Petrol _petrol = petrol;
    private Battery _battery = battery;
}