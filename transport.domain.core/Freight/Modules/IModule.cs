namespace transport.domain.core.Freight.Modules;

public interface IModule<out T>
{
    public T Id { get; }
    public string Name { get; }
    public string Description { get; }
    public FreightModels[] CompatibilityFreights { get; }
}