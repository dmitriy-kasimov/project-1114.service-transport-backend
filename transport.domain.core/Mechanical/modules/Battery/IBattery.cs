namespace transport.domain.core.Mechanical.modules.Battery;

public class BatterySpecification(decimal maxCharge)
{
    public decimal MaxCharge => maxCharge;
}

public interface IBattery
{
    public BatterySpecification Specification { get;}
}