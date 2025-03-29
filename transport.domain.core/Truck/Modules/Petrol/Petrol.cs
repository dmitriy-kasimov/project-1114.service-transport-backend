namespace transport.domain.core.Truck.Modules.Petrol;

public class Petrol : IModule
{
    public string Name { get; }
    public string Description { get; }
    public TruckModels[] CompatibilityTrucks { get;  }
    
    public float Capacity { get; }

    public Petrol(string name, string description, TruckModels[] compatibilityTrucks, float capacity)
    {
        Name = name;
        Description = description;
        CompatibilityTrucks = compatibilityTrucks;
  
        Capacity = capacity;
    }
}