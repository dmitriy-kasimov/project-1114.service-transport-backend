
using transport.domain.core.Freight.Modules.Axis;
using transport.domain.core.Freight.Modules.Engine;
using transport.domain.core.Freight.Modules.Petrol;
using transport.domain.core.Freight.Modules.Battery;

namespace transport.domain.core.Freight.Modules;

public class FreightModules
{
    public AxisIds[] CompatibilityAxis;
    public Axis.Axis Axis { get; }
    
    public EngineIds[] CompatibilityEngines;
    public Engine.Engine Engine { get; }
    
    public PetrolIds[] CompatibilityPetrol;
    public Petrol.Petrol Petrol { get; } 
    
    public BatteryIds[] CompatibilityBatteries;
    public Battery.Battery Battery { get; }

    public FreightModules(
        AxisIds[] compatibilityAxis, Axis.Axis axis, 
        EngineIds[] compatibilityEngines, Engine.Engine engine, 
        PetrolIds[] compatibilityPetrol, Petrol.Petrol petrol, 
        BatteryIds[] compatibilityBatteries, Battery.Battery battery)
    {
        CompatibilityAxis = compatibilityAxis;
        Axis = axis;
        
        CompatibilityEngines = compatibilityEngines;
        Engine = engine;
        
        CompatibilityPetrol = compatibilityPetrol;
        Petrol = petrol;
        
        CompatibilityBatteries = compatibilityBatteries;
        Battery = battery;
    }
}