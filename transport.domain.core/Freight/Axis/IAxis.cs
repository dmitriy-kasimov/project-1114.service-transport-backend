namespace transport.domain.core.Freight.Axis;

public interface IAxis
{
    public string Name { get; }
    public string Description { get; }
    public float MaxCapacity { get; }
}