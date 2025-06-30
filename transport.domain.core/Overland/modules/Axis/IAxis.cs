namespace transport.domain.core.Overland.modules.Axis;

public class AxisSpecification<T>(T axis)
{
    public T Axis => axis;
}

public interface IAxis<T>
{
    public AxisSpecification<T> Specification { get; }
}