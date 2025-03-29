namespace transport.domain.core.Truck.Modules.Axis;

public class Axis : IModule
{
    public string Name { get; }
    public string Description { get; }
    public TruckModels[] CompatibilityTrucks { get;  }
    
    public AxisType Type { get; }
    public float Capacity { get; }

    public Axis(string name, string description, TruckModels[] compatibilityTrucks, AxisType type, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityTrucks = compatibilityTrucks;
        Type = type;
        Capacity = capacity;
    }
}