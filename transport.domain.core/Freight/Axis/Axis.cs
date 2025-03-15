namespace transport.domain.core.Freight.Axis;

public class Axis : IAxis
{
    public string Name { get; }
    public string Description { get; }
    public float MaxCapacity { get; }

    public Axis(float maxCapacity)
    {
        MaxCapacity = maxCapacity;
    }
}