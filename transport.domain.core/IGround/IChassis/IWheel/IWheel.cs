namespace transport.domain.core.IGround.IChassis.IWheel;

public interface IWheel : IChassis
{
    public new ChassisScheme ChassisScheme { get; } 
    public int Count { get; }
    public WheelScheme Scheme { get; }
}