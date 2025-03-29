
using transport.domain.core.Truck.Modules.Axis;
using transport.domain.core.Truck.Modules.Engine;
using transport.domain.core.Truck.Modules.Petrol;
using transport.domain.core.Truck.Modules.Battery;

namespace transport.domain.core.Truck.Modules;

public class TruckModules
{
    public AxisModels[] CompatibilityAxis;
    public Axis.Axis Axis { get; }
    
    public EngineModels[] CompatibilityEngines;
    public Engine.Engine Engine { get; }
    
    public PetrolModels[] CompatibilityPetrol;
    public Petrol.Petrol Petrol { get; } 
    
    public BatteryModels[] CompatibilityBatteries;
    public Battery.Battery Battery { get; }

    public TruckModules(
        AxisModels[] compatibilityAxis, Axis.Axis axis, 
        EngineModels[] compatibilityEngines, Engine.Engine engine, 
        PetrolModels[] compatibilityPetrol, Petrol.Petrol petrol, 
        BatteryModels[] compatibilityBatteries, Battery.Battery battery)
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