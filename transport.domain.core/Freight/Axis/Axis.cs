namespace transport.domain.core.Freight.Axis;

public class Axis : IAxis
{
    public string Id { get; }
    public string Name { get; }
    public string Description { get; }
    public float MaxCapacity { get; }

    public Axis(string id, string name, string description, float maxCapacity)
    {
        Id = id;
        Name = name;
        Description = description;
        MaxCapacity = maxCapacity;
    }
}