namespace transport.domain.core.subsection.Mechanical.Platform.Fuel.PowerSupply;

public interface IFuelPowerSupply : IPowerSupply
{
    public new string Name { get; }
    public new string Description { get; }
    public float RatedCapacity { get; }
}