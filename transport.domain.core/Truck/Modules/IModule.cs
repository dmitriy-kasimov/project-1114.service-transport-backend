namespace transport.domain.core.Truck.Modules;

public interface IModule
{
    public string Name { get; }
    public string Description { get; }
    public TruckModels[] CompatibilityTrucks { get; }
}