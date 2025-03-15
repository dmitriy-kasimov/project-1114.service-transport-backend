namespace transport.domain.core.IMechanical.IPlatform.IFuel;

public interface IFuelPlatform : IPlatform
{
    public new IFuelEngine Engine { get; }
    public new IFuelPowerSupply PowerSupply { get; }
    public IFuelPetrol FuelPetrol {get; }
}