namespace transport.domain.core.IMechanical.IPlatform;

public interface IPlatform
{
    public IEngine Engine { get; }
    public IPowerSupply PowerSupply { get; }
}