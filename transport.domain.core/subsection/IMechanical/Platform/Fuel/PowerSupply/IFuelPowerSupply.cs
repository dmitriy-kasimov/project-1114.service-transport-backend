namespace transport.domain.core.subsection.IMechanical.Platform.Fuel.PowerSupply;

public interface IFuelPowerSupply : IPowerSupply
{
    public new string Name { get; }
    public new string Description { get; }
    public float RatedCapacity { get; }
}