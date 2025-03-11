namespace transport.domain.core.IMechanical.IPlatform.IElectric;

public interface IElectric : IPlatform
{
    public new IElectricEngine Engine { get; set; }
    public new IElectricPowerSupply PowerSupply { get; set; }
}