
using transport.domain.core.Truck.Modules.Axis;
using transport.domain.core.Truck.Modules.Engine;
using transport.domain.core.Truck.Modules.Petrol;
using transport.domain.core.Truck.Modules.Battery;

namespace transport.domain.core.Truck.Modules;

public class TruckModules
{
    public AxisIds[] CompatibilityAxis;
    public Axis.Axis Axis { get; }
    
    public EngineIds[] CompatibilityEngines;
    public Engine.Engine Engine { get; }
    
    public PetrolIds[] CompatibilityPetrol;
    public Petrol.Petrol Petrol { get; } 
    
    public BatteryIds[] CompatibilityBatteries;
    public Battery.Battery Battery { get; }

    public TruckModules(
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