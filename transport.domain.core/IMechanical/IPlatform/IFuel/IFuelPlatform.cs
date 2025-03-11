namespace transport.domain.core.IMechanical.IPlatform.IFuel;

public interface IFuelPlatform : IPlatform
{
    public new IFuelEngine Engine { get; set; }
    public new IFuelPowerSupply PowerSupply { get; set; }
    public IFuelPetrol FuelPetrol {get; set; }
}