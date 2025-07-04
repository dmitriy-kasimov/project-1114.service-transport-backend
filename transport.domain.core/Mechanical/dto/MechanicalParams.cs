using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;

namespace transport.domain.core.Mechanical.dto;

public class MechanicalParams<T, TA>(
    List<Guid> compatiblyEngines, Engine<T, TA> engine, 
    List<Guid> compatiblyPetrol, Petrol<T, TA> petrol, 
    List<Guid> compatiblyBatteries, Battery<TA> battery)
{
    public List<Guid> CompatiblyEngines => compatiblyEngines;
    public Engine<T, TA> Engine => engine;
    
    public List<Guid> CompatiblyPetrol => compatiblyPetrol;
    public Petrol<T, TA> Petrol => petrol;
    
    public List<Guid> CompatiblyBatteries => compatiblyBatteries;
    public Battery<TA> Battery => battery;
}