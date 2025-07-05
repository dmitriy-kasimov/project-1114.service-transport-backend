using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;

namespace transport.domain.core.Mechanical.dto;

public class MechanicalParams<T, TA>(
    List<string> compatiblyEngines, Engine<T, TA> engine, 
    List<string> compatiblyPetrol, Petrol<T, TA> petrol, 
    List<string> compatiblyBatteries, Battery<TA> battery)
{
    public List<string> CompatiblyEngines => compatiblyEngines;
    public Engine<T, TA> Engine => engine;
    
    public List<string> CompatiblyPetrol => compatiblyPetrol;
    public Petrol<T, TA> Petrol => petrol;
    
    public List<string> CompatiblyBatteries => compatiblyBatteries;
    public Battery<TA> Battery => battery;
}