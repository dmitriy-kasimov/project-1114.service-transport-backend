namespace transport.domain.core.Freight.Modules.Engine;

public class Engine : IModule
{
    public string Name { get; }
    public string Description { get; }
    public FreightModels[] CompatibilityFreights { get;  }
    
    public TypeFuel[] FuelTypes { get; }

    public Engine(string name, string description, FreightModels[] compatibilityFreights, TypeFuel[] fuelTypes)
    {
        Name = name;
        Description = description;
        CompatibilityFreights = compatibilityFreights;
  
        FuelTypes = fuelTypes;
    }
}