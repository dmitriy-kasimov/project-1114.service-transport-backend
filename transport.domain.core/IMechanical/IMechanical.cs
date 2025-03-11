namespace transport.domain.core.IMechanical;

public interface IMechanical
{
    public IPlatform.IPlatform Platform { get; set; }
    public IChassis.IChassis Chassis { get; set; }
}