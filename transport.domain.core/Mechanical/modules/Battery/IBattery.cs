namespace transport.domain.core.Mechanical.modules.Battery;

public class BatterySpecification(float maxCharge)
{
    public float MaxCharge => maxCharge;
}

public interface IBattery
{
    public BatterySpecification Specification { get;}
}