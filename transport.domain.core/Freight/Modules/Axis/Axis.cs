namespace transport.domain.core.Freight.Modules.Axis;

public class Axis : IModule
{
    public string Name { get; }
    public string Description { get; }
    public FreightModels[] CompatibilityFreights { get;  }
    
    public AxisType Type { get; }
    public float Capacity { get; }

    public Axis(string name, string description, FreightModels[] compatibilityFreights, AxisType type, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityFreights = compatibilityFreights;
        Type = type;
        Capacity = capacity;
    }
}