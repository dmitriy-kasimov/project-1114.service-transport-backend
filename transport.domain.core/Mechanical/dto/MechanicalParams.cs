using transport.domain.core.Mechanical.modules.Battery;
using transport.domain.core.Mechanical.modules.Engine;
using transport.domain.core.Mechanical.modules.Petrol;

namespace transport.domain.core.Mechanical.dto;

public class MechanicalParams<T, TA>(
    List<string> compatiblyEngines, string defaultEngineModel, Engine<T, TA> engine, 
    List<string> compatiblyPetrol, string defaultPetrolModel, Petrol<T, TA> petrol, 
    List<string> compatiblyBatteries, string defaultBatteryModel, Battery<TA> battery)
{
    public List<string> CompatiblyEngines => compatiblyEngines;
    public string DefaultEngineModel => defaultEngineModel;
    public Engine<T, TA> Engine => engine;
    
    public List<string> CompatiblyPetrol => compatiblyPetrol;
    public string DefaultPetrolModel => defaultPetrolModel;
    public Petrol<T, TA> Petrol => petrol;
    
    public List<string> CompatiblyBatteries => compatiblyBatteries;
    public string DefaultBatteryModel => defaultBatteryModel;
    public Battery<TA> Battery => battery;
}