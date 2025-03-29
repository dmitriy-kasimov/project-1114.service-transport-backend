namespace transport.domain.core.Truck.Modules.Battery;

public class Battery : IModule
{
    public string Name { get; }
    public string Description { get; }
    public TruckModels[] CompatibilityTrucks { get;  }
    
    public float Capacity { get; }

    public Battery(string name, string description, TruckModels[] compatibilityTrucks, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityTrucks = compatibilityTrucks;
  
        Capacity = capacity;
    }
}