namespace transport.domain.core.IGround.IChassis.WheelChassis;

public class WheelChassis : IChassis
{
    public string Name { get; }

    public EWheelAxis WheelAxis { get; }

    public WheelChassis(string name, EWheelAxis wheelAxis)
    {
        Name = name;
        WheelAxis = wheelAxis;
    }
}