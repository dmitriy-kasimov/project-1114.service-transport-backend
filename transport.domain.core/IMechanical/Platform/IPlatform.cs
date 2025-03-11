namespace transport.domain.core.IMechanical.Platform;

public interface IPlatform
{
    public IEngine Engine { get; set; }
    public IPowerSupply PowerSupply { get; set; }
}