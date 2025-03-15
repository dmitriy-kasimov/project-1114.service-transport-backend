namespace transport.domain.core.IMechanical.IPlatform.IElectric;

public interface IElectricPlatform : IPlatform
{
    public new IElectricEngine Engine { get; set; }
    public new IElectricPowerSupply PowerSupply { get; set; }
}