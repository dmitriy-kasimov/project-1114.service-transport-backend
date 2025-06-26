using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;

namespace transport.domain.core.Mechanical.dto;

public class MechanicalParams<T>(Engine<T> engine, Petrol<T> petrol, Battery battery)
{
    public Engine<T> Engine => engine;
    public Petrol<T> Petrol => petrol;
    public Battery Battery => battery;
}