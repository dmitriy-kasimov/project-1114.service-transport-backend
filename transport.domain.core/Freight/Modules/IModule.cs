namespace transport.domain.core.Freight.Modules;

public interface IModule
{
    public string Name { get; }
    public string Description { get; }
    public FreightIds[] CompatibilityFreights { get; }
}