namespace transport.domain.core.Freight.Modules.Petrol;

public class Petrol : IModule
{
    public string Name { get; }
    public string Description { get; }
    public FreightModels[] CompatibilityFreights { get;  }
    
    public float Capacity { get; }

    public Petrol(string name, string description, FreightModels[] compatibilityFreights, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityFreights = compatibilityFreights;
  
        Capacity = capacity;
    }
}