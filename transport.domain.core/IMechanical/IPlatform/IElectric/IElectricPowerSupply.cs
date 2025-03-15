namespace transport.domain.core.IMechanical.IPlatform.IElectric;

public interface IElectricPowerSupply : IPowerSupply
{
    public new string Name { get; }
    public new string Description { get; }
    public float PowerReserve { get; }
}