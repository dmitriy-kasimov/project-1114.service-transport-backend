namespace transport.domain.core.IMechanical.IPlatform;

public interface IPlatform
{
    public IEngine Engine { get; set; }
    public IPowerSupply PowerSupply { get; set; }
}