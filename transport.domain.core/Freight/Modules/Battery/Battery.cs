namespace transport.domain.core.Freight.Modules.Battery;

public class Battery : IModule
{
    public string Name { get; }
    public string Description { get; }
    public FreightModels[] CompatibilityFreights { get;  }
    
    public float Capacity { get; }

    public Battery(string name, string description, FreightModels[] compatibilityFreights, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityFreights = compatibilityFreights;
  
        Capacity = capacity;
    }
}