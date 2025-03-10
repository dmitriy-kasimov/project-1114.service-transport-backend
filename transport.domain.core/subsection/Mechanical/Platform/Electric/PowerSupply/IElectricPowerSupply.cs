namespace transport.domain.core.subsection.Mechanical.Platform.Electric.PowerSupply;

public interface IElectricPowerSupply : IPowerSupply
{
    public new string Name { get; }
    public new string Description { get; }
    public float PowerReserve {get; set;}
}