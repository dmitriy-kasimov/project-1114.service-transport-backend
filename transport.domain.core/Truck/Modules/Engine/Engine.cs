namespace transport.domain.core.Truck.Modules.Engine;

public class Engine : IModule
{
    public string Name { get; }
    public string Description { get; }
    public TruckModels[] CompatibilityTrucks { get;  }
    
    public TypeFuel[] FuelTypes { get; }

    public Engine(string name, string description, TruckModels[] compatibilityTrucks, TypeFuel[] fuelTypes)
    {
        Name = name;
        Description = description;
        CompatibilityTrucks = compatibilityTrucks;
  
        FuelTypes = fuelTypes;
    }
}