namespace transport.domain.core.Truck.Modules.Battery;

public class Battery : IModule
{
    public string Name { get; }
    public string Description { get; }
    public TrucksIds[] CompatibilityTrucks { get;  }
    
    public float Capacity { get; }

    public Battery(string name, string description, TrucksIds[] compatibilityFreights, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityTrucks = compatibilityFreights;
  
        Capacity = capacity;
    }
}