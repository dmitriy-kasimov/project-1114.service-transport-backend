namespace transport.domain.core.Freight.Modules.Axis;

public class Axis : IModule<AxisModels>
{
    public AxisModels Id { get; }
    public string Name { get; }
    public string Description { get; }
    public FreightModels[] CompatibilityFreights { get;  }
    
    public AxisType Type { get; }
    public float Capacity { get; }

    public Axis(AxisModels id, string name, string description, FreightModels[] compatibilityFreights, AxisType type, float capacity)
    {
        Id = id;
        Name = name;
        Description = description;
        CompatibilityFreights = compatibilityFreights;
        Type = type;
        Capacity = capacity;
    }
}