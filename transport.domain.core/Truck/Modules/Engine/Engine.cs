namespace transport.domain.core.Truck.Modules.Engine;

public class Engine : IModule
{
    public string Name { get; }
    public string Description { get; }
    public TrucksIds[] CompatibilityTrucks { get;  }
    
    public TypeFuel[] FuelTypes { get; }

    public Engine(string name, string description, TrucksIds[] compatibilityFreights, TypeFuel[] fuelTypes)
    {
        Name = name;
        Description = description;
        CompatibilityTrucks = compatibilityFreights;
  
        FuelTypes = fuelTypes;
    }
}