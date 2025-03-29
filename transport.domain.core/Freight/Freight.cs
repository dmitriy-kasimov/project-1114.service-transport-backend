using transport.domain.core.Freight.Modules.Axis;
using transport.domain.core.Freight.Modules.Engine;
using transport.domain.core.Freight.Modules.Petrol;
using transport.domain.core.Freight.Modules.Battery;

namespace transport.domain.core.Freight;

public class Freight
{
    public string Name { get; }
    public string Description { get; }

    public AxisIds[] CompatibilityAxis;
    public Axis Axis { get; }
    
    public EngineIds[] CompatibilityEngines;
    public Engine Engine { get; }
    
    public PetrolIds[] CompatibilityPetrol;
    public Petrol Petrol { get; } 
    
    public BatteryIds[] CompatibilityBatteries;
    public Battery Battery { get; }

    public Freight(string name, string description, 
        AxisIds[] compatibilityAxis, Axis axis, 
        EngineIds[] compatibilityEngines, Engine engine, 
        PetrolIds[] compatibilityPetrol, Petrol petrol, 
        BatteryIds[] compatibilityBatteries, Battery battery)
    {
        Name = name;
        Description = description;
        
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