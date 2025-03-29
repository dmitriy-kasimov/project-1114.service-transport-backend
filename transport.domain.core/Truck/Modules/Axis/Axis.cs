namespace transport.domain.core.Truck.Modules.Axis;

public class Axis : IModule
{
    public string Name { get; }
    public string Description { get; }
    public TrucksIds[] CompatibilityTrucks { get;  }
    
    public AxisType Type { get; }
    public float Capacity { get; }

    public Axis(string name, string description, TrucksIds[] compatibilityFreights, AxisType type, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityTrucks = compatibilityFreights;
        Type = type;
        Capacity = capacity;
    }
}