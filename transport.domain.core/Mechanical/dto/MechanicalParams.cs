using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;

namespace transport.domain.core.Mechanical.dto;

public class MechanicalParams<T, TA>(Engine<T, TA> engine, Petrol<T, TA> petrol, Battery<TA> battery)
{
    public Engine<T, TA> Engine => engine;
    public Petrol<T, TA> Petrol => petrol;
    public Battery<TA> Battery => battery;
}