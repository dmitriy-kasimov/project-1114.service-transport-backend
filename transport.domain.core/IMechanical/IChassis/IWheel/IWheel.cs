namespace transport.domain.core.IMechanical.IChassis.IWheel;

public interface IWheel : IChassis
{
    public new ChassisScheme ChassisScheme { get; } 
    public int Count { get; }
    public WheelScheme Scheme { get; }
}