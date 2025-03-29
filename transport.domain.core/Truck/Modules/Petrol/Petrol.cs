namespace transport.domain.core.Truck.Modules.Petrol;

public class Petrol : IModule
{
    public string Name { get; }
    public string Description { get; }
    public TrucksIds[] CompatibilityTrucks { get;  }
    
    public float Capacity { get; }

    public Petrol(string name, string description, TrucksIds[] compatibilityFreights, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityTrucks = compatibilityFreights;
  
        Capacity = capacity;
    }
}