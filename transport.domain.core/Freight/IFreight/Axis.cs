namespace transport.domain.core.Freight.IFreight;

public class Axis
{
    public float MaxCapacity { get; set; }

    public Axis(float MaxCapacity)
    {
        this.MaxCapacity = MaxCapacity;
    }
}